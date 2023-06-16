using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.XamarinForms.Paginas.PaginaDeNavegacao
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Conteudo03 : ContentPage
    {
        public Conteudo03()
        {
            InitializeComponent();
        }

        protected override bool OnBackButtonPressed()
        {
            return true;
        }

        private void VoltarPagina02(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        private void Home(object sender, EventArgs e)
        {
            Navigation.PopToRootAsync();
        }

        private void InserirPagina(object sender, EventArgs e)
        {

            Navigation.InsertPageBefore(
                    new Conteudo01(),
                    this
                );
        }

        private void RemoverPagina(object sender, EventArgs e)
        {
            Navigation.RemovePage(Navigation.NavigationStack[0]);
        }

        
    }
}