using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; // Necesario para trabajar con rutas de archivos

namespace Currency
{
    public partial class Form1 : Form
    {
        private string apiKey = "9cf4cf581cd95614a18a2e5b"; // Reemplaza con tu clave API

        // Diccionario para mapear el código de la moneda a su nombre completo
        private Dictionary<string, string> monedas = new Dictionary<string, string>()
        {
            { "USD", "Dólar Estadounidense" },
            { "CRC", "Colón Costarricense" },
            { "EUR", "Euro" }
        };

        public Form1()
        {
            InitializeComponent();

            // Establecer la imagen de fondo
            string imagePath = Path.Combine(Application.StartupPath, "Images", "Divisas2.png"); // Ruta a la imagen
            if (File.Exists(imagePath)) // Verificar si la imagen existe
            {
                this.BackgroundImage = System.Drawing.Image.FromFile(imagePath); // Establecer la imagen de fondo
                this.BackgroundImageLayout = ImageLayout.Stretch;    // Ajustar la imagen al tamaño del formulario
            }
            else
            {
                MessageBox.Show("Imagen no encontrada en la ruta especificada.");
            }

            // Agregar monedas al ComboBox con el nombre completo
            foreach (var moneda in monedas)
            {
                string item = $"{moneda.Key} - {moneda.Value}"; // Combina código y nombre
                cmbMonedaOrigen.Items.Add(item);
                cmbMonedaDestino.Items.Add(item);
            }

            // Seleccionar valores por defecto
            cmbMonedaOrigen.SelectedIndex = 0;
            cmbMonedaDestino.SelectedIndex = 1;
        }

        // Evento que se ejecuta cuando el usuario cambia la cantidad o selecciona una moneda
        private async void OnInputChanged(object sender, EventArgs e)
        {
            // Verificar que la cantidad sea válida antes de hacer la conversión
            if (decimal.TryParse(txtCantidad.Text, out decimal cantidad))
            {
                await RealizarConversion(cantidad);
            }
            else
            {
                // Si la cantidad no es válida, limpiar el resultado
                txtResultado.Text = string.Empty;
            }
        }

        // Este es el método principal que realiza la conversión
        private async Task RealizarConversion(decimal cantidad)
        {
            try
            {
                // Obtener las monedas seleccionadas
                string monedaOrigen = cmbMonedaOrigen.SelectedItem.ToString().Split(' ')[0]; // Extraer solo el código
                string monedaDestino = cmbMonedaDestino.SelectedItem.ToString().Split(' ')[0]; // Extraer solo el código

                // Llamar a la API para obtener la tasa de cambio
                string url = $"https://v6.exchangerate-api.com/v6/{apiKey}/latest/{monedaOrigen}";

                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(url);
                    response.EnsureSuccessStatusCode(); // Asegura que la respuesta es exitosa

                    string responseBody = await response.Content.ReadAsStringAsync(); // Leer la respuesta
                    var data = JsonConvert.DeserializeObject<dynamic>(responseBody); // Deserializar la respuesta JSON

                    // Obtener la tasa de cambio
                    decimal tasaCambio = data.conversion_rates[monedaDestino];

                    // Realizar la conversión
                    decimal resultado = cantidad * tasaCambio;

                    // Mostrar el resultado en el TextBox de resultado
                    txtResultado.Text = resultado.ToString("N0"); // Formatear con 2 decimales
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al realizar la conversión: {ex.Message}"); // Mostrar error si ocurre algún problema
            }
        }

        // Si decides usar el botón para la conversión en lugar de los eventos de cambio automático
        private async void btnConvertir_Click(object sender, EventArgs e)
        {
            // Verificar si la cantidad ingresada es válida
            if (decimal.TryParse(txtCantidad.Text, out decimal cantidad))
            {
                // Si es válida, realizar la conversión
                await RealizarConversion(cantidad);
            }
            else
            {
                // Si la cantidad no es válida, mostrar un mensaje de error
                MessageBox.Show("Por favor ingresa una cantidad válida.");
            }
        }

        private void cmbMonedaOrigen_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Este evento puede ser usado si es necesario hacer algo cuando cambia la moneda de origen
        }

        private void lblMonedaOrigen_Click(object sender, EventArgs e)
        {

        }
    }
}
