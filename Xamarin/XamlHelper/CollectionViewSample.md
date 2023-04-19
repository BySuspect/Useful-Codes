* Xaml
```
<CollectionView ItemsSource="{Binding Animals}">
    <CollectionView.ItemTemplate>
        <DataTemplate>
            <StackLayout>
                <Label Text="{Binding Name}" FontSize="Large" />
                <Label Text="{Binding Description}" />
                <Image Source="{Binding ImageUrl}" Aspect="AspectFill" HeightRequest="200" />
            </StackLayout>
        </DataTemplate>
    </CollectionView.ItemTemplate>
</CollectionView>
```

* C#
```
public class Animal
{
    public string Name { get; set; }
    public string Description { get; set; }
    public string ImageUrl { get; set; }
}


public class myPage
{
    public ObservableCollection<Animal> Animals { get; set; }

    public MainViewModel()
    {
        Animals = new ObservableCollection<Animal>
        {
            new Animal { Name = "Lion", Description = "The king of the jungle", ImageUrl = "https://www.example.com/lion.jpg" },
            new Animal { Name = "Elephant", Description = "The largest land animal", ImageUrl = "https://www.example.com/elephant.jpg" },
            new Animal { Name = "Giraffe", Description = "The tallest land animal", ImageUrl = "https://www.example.com/giraffe.jpg" }
        };
    }
}
```
