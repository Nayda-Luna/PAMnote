using System.Net.Security;

namespace PAMnotes
{
    public partial class MainPage : ContentPage
    {

        string filePath = Path.Combine(FileSystem.AppDataDirectory, "Notes.txt");
        public MainPage()
        {
            InitializeComponent();
     
            if (File.Exists(filePath) == true) 
            {
                NoteEditor.Text = File.ReadAllText(filePath);
             }
        }

        private void SaveButton_Clicked(object sender, EventArgs e)
        {
            string texto = NoteEditor.Text;
            TextLabel.Text = texto;
            File.WriteAllText(filePath, texto);
            DisplayAlert("Sucesso", "Operação concluída", "Ok");



        }

        private void DeleteButton_Clicked(object sender, EventArgs e)
        {
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
                DisplayAlert("Sucesso", "Operação concluída com sucesso", "Ok");
            }
            else
            {
                DisplayAlert("Alerta", "Aquivo não encontrado", "Ok");
            }

        }
    }
 }
            

            
              
    


