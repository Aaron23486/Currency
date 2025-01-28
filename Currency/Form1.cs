using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Currency
{
    public partial class Form1 : Form
    {
        private string apiKey = "9cf4cf581cd95614a18a2e5b"; // Reemplaza con tu clave API

        private Dictionary<string, string> monedas = new Dictionary<string, string>()
        {
            { "USD", "Dólar Estadounidense" },
            { "CRC", "Colón Costarricense" },
            { "EUR", "Euro" },
            { "CNY", "Yuan Chino" },
            { "COP", "Peso Colombiano" },
            { "BRL", "Real Brasileño" },
            { "PEN", "Sol Peruano" }
        };

        private Dictionary<string, string> simbolosMonedas = new Dictionary<string, string>()
        {
            { "USD", "$" },
            { "CRC", "₡" },
            { "EUR", "€" },
            { "CNY", "¥" },
            { "COP", "$" },
            { "BRL", "R$" },
            { "PEN", "S/." }
        };

        private decimal cantidadIngresada = 0; // Campo para almacenar la cantidad ingresada

        public Form1()
        {
            InitializeComponent();

            string imagePath = Path.Combine(Application.StartupPath, "Images", "Divisas2.png"); // Ruta a la imagen
            if (File.Exists(imagePath))
            {
                this.BackgroundImage = System.Drawing.Image.FromFile(imagePath);
                this.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else
            {
                MessageBox.Show("Imagen no encontrada en la ruta especificada.");
            }

            foreach (var moneda in monedas)
            {
                string item = $"{moneda.Key} - {moneda.Value}";
                cmbMonedaOrigen.Items.Add(item);
                cmbMonedaDestino.Items.Add(item);
            }

            cmbMonedaOrigen.SelectedIndex = 0;
            cmbMonedaDestino.SelectedIndex = 1;
        }

        // Evento que se ejecuta cuando el usuario cambia la cantidad o selecciona una moneda
        private async void OnInputChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtCantidad.Text, out decimal cantidad))
            {
                cantidadIngresada = cantidad; // Guardamos la cantidad ingresada
                await RealizarConversion(cantidad);
            }
            else
            {
                txtResultado.Text = string.Empty;
            }
        }

        // Este es el método principal que realiza la conversión
        private async Task RealizarConversion(decimal cantidad)
        {
            try
            {
                string monedaOrigen = cmbMonedaOrigen.SelectedItem.ToString().Split(' ')[0];
                string monedaDestino = cmbMonedaDestino.SelectedItem.ToString().Split(' ')[0];

                string simboloOrigen = simbolosMonedas[monedaOrigen];
                string simboloDestino = simbolosMonedas[monedaDestino];

                string url = $"https://v6.exchangerate-api.com/v6/{apiKey}/latest/{monedaOrigen}";

                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(url);
                    response.EnsureSuccessStatusCode();

                    string responseBody = await response.Content.ReadAsStringAsync();
                    var data = JsonConvert.DeserializeObject<dynamic>(responseBody);

                    decimal tasaCambio = data.conversion_rates[monedaDestino];

                    decimal resultado = cantidad * tasaCambio;

                    txtResultado.Text = $"{simboloDestino} {resultado.ToString("N0")}";
                    txtCantidad.Text = $"{simboloOrigen} {cantidad.ToString("N0")}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al realizar la conversión: {ex.Message}");
            }
        }

        // Evento para cambiar monedas
        private async void cmbMonedaOrigen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cantidadIngresada > 0)
            {
                await RealizarConversion(cantidadIngresada); // Realizamos la conversión con la cantidad previamente ingresada
            }
        }

        private async void cmbMonedaDestino_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cantidadIngresada > 0)
            {
                await RealizarConversion(cantidadIngresada); // Realizamos la conversión con la cantidad previamente ingresada
            }
        }

        // Método para el botón de conversión
        private async void btnConvertir_Click(object sender, EventArgs e)
        {
            // Eliminar cualquier texto que no sea el número de la cantidad
            string cantidadTexto = txtCantidad.Text.Replace("₡", "").Replace("$", "").Replace("€", "").Replace("¥", "").Replace("R$", "").Replace("S/.", "").Trim();

            // Intentar parsear la cantidad como decimal
            if (decimal.TryParse(cantidadTexto, out decimal cantidad))
            {
                // Si la cantidad es válida, realizar la conversión
                await RealizarConversion(cantidad);
            }
            else
            {
                // Si la cantidad no es válida, mostrar un mensaje de error
                MessageBox.Show("Por favor ingresa una cantidad válida.");
            }
        }

    }
}
