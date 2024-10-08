﻿using XamControls.Models;
using XamControls.Utils;
using XamControls.ViewModels;
using System;
using System.Windows.Input;
using System.Threading.Tasks;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Linq;
using System.Text;
using Steema.TeeChart;
using Steema.TeeChart.Drawing;
using XamControls.Services;
using System.Threading;
using XamControls.CustomRenders;
// TODO using Naxam.Controls.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace XamControls.Views
{

    // Clase principal del Home
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomeView : ContentPage
    {

        HomeViewModel vm;
        private Xamarin.Forms.ListView lView = new Xamarin.Forms.ListView(ListViewCachingStrategy.RecycleElementAndDataTemplate);
        private Grid menuSuperior = new Grid();
        private List<ItemsListView> ListItems;
        private MasterView master;
        private NavigationBarViewModel navBar;
        private StackLayout stackPrincipal;
        private StackLayout stackLayoutGrid;
        bool uiInitialized;

        // Constructor de la "View"
        public HomeView()
        {

            stackLayoutGrid = new StackLayout();

            InitializeComponent();
            //Inicializar lista
            ListItems = IniciListItems();

            // Título de la aplicación
            this.Title = "TeeChart DEMO";
            this.BackgroundColor = Color.FromRgb(240, 240, 240);
            if (Device.RuntimePlatform == Device.Android) this.IconImageSource = new FileImageSource { File = "home_black_36dp.png" };
            else this.IconImageSource = new FileImageSource { File = "mic_home_black_36dp.png" };

            // Características de la "App" según el dispositivo
            switch (Device.RuntimePlatform)
            {
                case Device.Android:

                    // Grid "menuSuperior"
                    menuSuperior.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Auto) });
                    menuSuperior.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(0.15, GridUnitType.Star) });
                    menuSuperior.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(0.85, GridUnitType.Star) });
                    menuSuperior.BackgroundColor = Color.FromRgb(33, 150, 244);
                    menuSuperior.IsVisible = false;
                    menuSuperior.Margin = 0;

                    // Propiedades "ListView" en Android
                    lView.Margin = new Thickness(5, 0, 5, 0);
                    break;

                case Device.iOS:
                    // Propiedades "ListView" en iOS
                    lView.Margin = new Thickness(5, 10, 5, 5);
                    On<Xamarin.Forms.PlatformConfiguration.iOS>().SetUseSafeArea(true);
                    break;
            }

            // Propiedades "listView"
            lView.ItemsSource = ListItems;
            lView.RowHeight = 120;
            lView.ItemSelected += (sender, e) => { ((Xamarin.Forms.ListView)sender).SelectedItem = null; };
            lView.ItemTapped += ItemsListView_ChangeActivity;
            lView.SeparatorVisibility = SeparatorVisibility.None;
            DataTemplatelView();
            ListViewCachingStrategy.RetainElement.Equals(lView);

            // Mostrar elementos
            stackLayoutGrid = new StackLayout()
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Children =
                {
                    menuSuperior, lView,
                },
                Margin = 0,
                Spacing = 0
            };

            // Condiciones para algunos elementos
            if (vm == null)
                ViewModel = new HomeViewModel();
        }

        public HomeViewModel ViewModel
        {
            get => vm; set
            {
                vm = value;
                BindingContext = vm;
            }
        }

        // Contenido principal de la página
        public void CrearContenido()
        {

            stackPrincipal = new StackLayout();
            navBar = new NavigationBarViewModel(lView, ListItems, master) { Margin = 0, Spacing = 0 };
            this.Content = stackPrincipal;

            stackPrincipal.Spacing = 0;
            stackPrincipal.Margin = 0;
            if (Device.RuntimePlatform == Device.Android) stackPrincipal.Children.Add(navBar);
            stackPrincipal.Children.Add(stackLayoutGrid);

        }

        // Inicialización de la lista para el "listView"
        private List<ItemsListView> IniciListItems()
        {

            LViewDataStore lViewDataStore = new LViewDataStore();

            return lViewDataStore.GetListItems; ;

        }

        private int onlyOneClick = 0;

        // Funciones de los "Cells" al clicar en ellos
        private async void ItemsListView_ChangeActivity(object sender, ItemTappedEventArgs e)
        {
            int valor = 0;
            int posicioActual = 0;

            if (onlyOneClick == 0)
            {

                while (e.Item != ListItems[posicioActual])
                {

                    posicioActual++;

                }

                valor = posicioActual + 1;
                if (ListItems[posicioActual].Tipus == "PRO") { await DisplayAlert("Alert", "This section is only for subscribers.", "OK"); }

                onlyOneClick = 1;

                switch (ListItems[posicioActual].Id)
                {

                    case 1:
                    case 2:
                    case 15:

                        await Navigation.PushAsync(new ChartTabPage(ListItems[posicioActual].Id));
                        break;

                    default:

                        await Navigation.PushAsync(new ChartContentPage(ListItems[posicioActual].Id));
                        break;

                }
            }
        }

        // Crear "Cells" de la información necesaria
        private void DataTemplatelView()
        {
            lView.ItemTemplate = new DataTemplate(() =>
            {

                Image imagenItem = new Image();
                Grid gridPrincipal = new Grid();
                Grid gridInSuperior = new Grid();
                Label lblNom = new Label();
                Label lblTipus = new Label();
                Label lblInformacio = new Label();
                Label lblSamples = new Label();
                StackLayout stackLayoutInferior = new StackLayout();
                StackLayout stackLayoutTipus = new StackLayout();
                ViewCell vCell = new ViewCell();
                StackLayout viewStackLayout = new StackLayout();
                StackLayout viewStackLayout2 = new StackLayout();

                // Definiciones del "Grid" principal
                gridPrincipal.RowDefinitions.Add(new RowDefinition { Height = new GridLength(0.30, GridUnitType.Star) });
                gridPrincipal.RowDefinitions.Add(new RowDefinition { Height = new GridLength(0.70, GridUnitType.Star) });
                gridPrincipal.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(0.3, GridUnitType.Star) });
                gridPrincipal.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(0.7, GridUnitType.Star) });
                gridPrincipal.BackgroundColor = Color.White;
                gridPrincipal.VerticalOptions = LayoutOptions.StartAndExpand;

                // Definición de una "Image"
                imagenItem.SetBinding(Image.SourceProperty, "Foto");
                imagenItem.WidthRequest = 300;
                imagenItem.HeightRequest = 800;
                imagenItem.Margin = new Thickness(10, 5, 0, 5);

                // Definiciones del "Grid" superior (Title and Type)
                gridInSuperior.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
                gridInSuperior.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(0.75, GridUnitType.Star) });
                gridInSuperior.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(0.25, GridUnitType.Star) });

                // Nombre del apartado
                lblNom.SetBinding(Label.TextProperty, "Nom");
                lblNom.FontSize = 17;
                lblNom.VerticalOptions = LayoutOptions.Center;
                lblNom.TextColor = Color.Black;
                lblNom.Margin = new Thickness(0, 7, 0, 0);

                // Propiedades "stackLayoutTipus"
                stackLayoutTipus.BackgroundColor = Color.FromRgb(100, 200, 100);
                stackLayoutTipus.Padding = new Thickness(0, 4, 0, 0);
                stackLayoutTipus.Margin = new Thickness(1, 4, 4, 0);
                stackLayoutTipus.Children.Add(lblTipus);

                // Tipo de TeeChart (STD o PRO)
                lblTipus.SetBinding(Label.TextProperty, "Tipus");
                lblTipus.BackgroundColor = Color.FromRgb(100, 200, 100);
                lblTipus.HorizontalTextAlignment = TextAlignment.Center;
                lblTipus.VerticalTextAlignment = TextAlignment.Center;
                lblTipus.HorizontalOptions = LayoutOptions.Center;
                lblTipus.TextColor = Color.White;
                lblTipus.FontSize = 12;

                // Añadir texto al "Grid"
                gridInSuperior.Children.Add(lblNom, 0, 0);
                gridInSuperior.Children.Add(stackLayoutTipus, 1, 0);

                // Otros datos
                lblInformacio.SetBinding(Label.TextProperty, "Informacio");
                lblInformacio.TextColor = Color.Black;
                lblInformacio.FontSize = 11.5;
                lblInformacio.VerticalTextAlignment = TextAlignment.Start;

                // Texto "Samples"
                lblSamples.SetBinding(Label.TextProperty, "Samples");
                lblSamples.FontSize = 10;

                // Añadir elementos al "stackLayout" inferior
                stackLayoutInferior.Children.Add(lblInformacio);
                stackLayoutInferior.Children.Add(lblSamples);

                // Añadir texto al "Grid" y hacer una columna de 2 filas
                gridPrincipal.Children.Add(imagenItem, 0, 0);
                Grid.SetRowSpan(imagenItem, 2);
                gridPrincipal.Children.Add(gridInSuperior, 1, 0);
                gridPrincipal.Children.Add(stackLayoutInferior, 1, 1);
                gridPrincipal.RowSpacing = 5;
                gridPrincipal.ColumnSpacing = 15;

                // Refresh
                lView.IsPullToRefreshEnabled = false;
                lView.Refreshing += RefreshlViewAsync;

                // Creación de la "viewCell" y devolverla
                // {{{{{{{{{{ vCell.SetBinding(ViewCell.IsEnabledProperty, "Enabled"); }}}}}}}}}}
                vCell.View = viewStackLayout;
                gridPrincipal.SetBinding(BackgroundColorProperty, "BColor");
                viewStackLayout.Padding = new Thickness(0, 5);
                viewStackLayout.Orientation = StackOrientation.Horizontal;
                viewStackLayout.Children.Add(viewStackLayout2);
                viewStackLayout2.VerticalOptions = LayoutOptions.Center;
                viewStackLayout2.Spacing = 0;
                viewStackLayout2.Children.Add(gridPrincipal);

                // Devuelve la Cell
                return vCell;
            });
        }

        // Refresh "listView"
        private async void RefreshlViewAsync(object sender, EventArgs e)
        {
            DataTemplatelView();
            await Task.Delay(1200);
            lView.IsRefreshing = false;
        }

        void OnSelection(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
            {
                return; //ItemSelected is called on deselection, which results in SelectedItem being set to null
            }
            DisplayAlert("Item Selected", e.SelectedItem.ToString(), "Ok");
            //((ListView)sender).SelectedItem = null; //uncomment line if you want to disable the visual selection state.
        }


        protected override void OnSizeAllocated(double width, double height)
        {
            base.OnSizeAllocated(width, height);
            if (!uiInitialized)
            {
                //SearchForm.TranslateTo(width, 0, 0);
                uiInitialized = true;
            }
        }

        protected override SizeRequest OnMeasure(double widthConstraint, double heightConstraint)
        {
            return base.OnMeasure(widthConstraint, heightConstraint);
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            onlyOneClick = 0;
            vm?.OnAppearing();

            Xamarin.Forms.NavigationPage.SetBackButtonTitle(this, string.Empty);
        }

        public MasterView SetMaster { set { master = value; } }
        public Xamarin.Forms.ListView GetListView { get { return lView; } }

    }
}
