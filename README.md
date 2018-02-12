# listview
Show list of items in Xamarin forms using a REST service

This application shows how to display a item list by calling a REST service deployed in Azure

Item Service Controller returns list of items like this.

    private IItemService _itemService;

    public ItemsController(IItemService itemService)
    {
        _itemService = itemService;
     }

     // GET: api/Item
     [HttpGet]
     public IEnumerable<Item> Get()
     {
        var items = _itemService.GetItems();
        return items;
      }

Item list view shows as below,

```html
    <ListView x:Name="listView" SeparatorColor="Green">
        <ListView.ItemTemplate>
            <DataTemplate>
                <ViewCell>
                    <ViewCell.View>
                        <Grid>
                            <Grid.RowDefinitions>
                                <RowDefinition Height="*"/>
                                <RowDefinition Height="*"/>
                            </Grid.RowDefinitions>
                            <Grid.ColumnDefinitions>
                                <ColumnDefinition Width="*"/>
                                <ColumnDefinition Width="*"/>
                            </Grid.ColumnDefinitions>
                            <Label Grid.Row="0" Grid.Column="0" Text="{Binding Name}" FontSize="Medium" 
                                   TextColor="#065C2B"/>
                            <Label Grid.Row="0" Grid.Column="1" Text="{Binding Price}" FontSize="Small" 
                                   TextColor="#065C2B"/>
                            <Label Grid.Row="1" Grid.Column="0" Grid.ColumnSpan="2" 
                                   Text="{Binding Description}" FontSize="Small" TextColor="#6FCF97"/>
                        </Grid>
                    </ViewCell.View>

                </ViewCell>
            </DataTemplate>
        </ListView.ItemTemplate>
    </ListView>
```
You can call the display list method from the code behind file like this,

    class PizzaService : IPizzaService
     {

        HttpClient client;
        private string url = "https://pizzastore1.azurewebsites.net/api/item";

        public PizzaService()
        {
            client = new HttpClient();
            client.MaxResponseContentBufferSize = 256000;
        }

        public async Task<List<Item>> GetPizzasAsync()
        {
            List<Item> pizza = new List<Item>();
            var uri = new Uri(string.Format(url, string.Empty));
            try
            {
                var response = await client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    pizza = JsonConvert.DeserializeObject<List<Item>>(content);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"ERROR {0}", ex.Message);
            }
            return pizza;
        }
    }
