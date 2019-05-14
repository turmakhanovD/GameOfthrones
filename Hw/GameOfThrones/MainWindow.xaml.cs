using Gecko;
using System.Collections.Generic;
using System.Windows;
using System.IO;
using System.Net;
using Newtonsoft.Json;
using System.Linq;
using System.Windows.Media;
using System;
using System.Windows.Media.Imaging;

namespace GameOfThrones
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Character> _items = new List<Character>();

        public MainWindow()
        {
            InitializeComponent();
            Gecko.Xpcom.Initialize("Firefox");
            FillCharacters();
        }

        private void WindowLoaded(object sender, RoutedEventArgs e)
        {
            GeckoWebBrowser browser = new GeckoWebBrowser();
            host.Child = browser;
            //   GridWeb.Children.Add(host);

            browser.Navigate("http://viewers-guide.hbo.com/game-of-thrones/season-6/episode-10/map/location/77/bay-of-dragons");
        }

        private void FillCharacters()
        {
            var httpWebRequest = (System.Net.HttpWebRequest)WebRequest.Create("https://api.got.show/api/book/characters");

            httpWebRequest.ContentType = "text/json";
            httpWebRequest.Method = "GET";//Можно GET
            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                //ответ от сервера
                var result = streamReader.ReadToEnd();

                //Сериализация
                _items = JsonConvert.DeserializeObject<List<Character>>(result);

                foreach (var character in _items)
                {
                    characterList.Items.Add(character.Name);
                    
                }
            }
        }

        private void SearchCharacter(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {

            if (string.IsNullOrWhiteSpace(search.Text))
            {
                foreach (var item in _items)
                    characterList.Items.Add(item.Name);
            }
            else
            {
                characterList.Items.Clear();
                List<Character> searchItems = _items.Where(s => s.Name.Contains(search.Text)).ToList();
                foreach(var item in searchItems)
                characterList.Items.Add(item.Name);
            }
        }

        private void OpenCharacterInfo(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if(characterList.SelectedItem!=null)
            {

                Character character = new Character() ;
                var itemToSearch = _items.Where(x => x.Name == characterList.SelectedItem.ToString());
                foreach (var item in _items)
                {
                    if (item == itemToSearch.FirstOrDefault())
                    {
                         character=item;
                    }
                }

                CharacterAbout characterAbout = new CharacterAbout();
                string imgUri = character.Image;
                if (imgUri != null)
                {
                    Uri uri = new Uri(imgUri);
                    BitmapImage img = new BitmapImage(uri);
                   
                characterAbout.characterImg.Source = img;
                }
                characterAbout.nameLabel.Content = character.Name;
                characterAbout.genderLabel.Content = character.Gender;
                characterAbout.houseLabel.Content = character.House;
                characterAbout.slugLabel.Content = character.Slug;
                characterAbout.Show();
            }
            }
    }
}

