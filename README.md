# How to bind the list of string to WPF DataGrid(SfDataGrid)?

## About the sample

This sample illustrates how to bind the list of string to [WPF DataGrid](https://www.syncfusion.com/wpf-ui-controls/datagrid) (SfDataGrid).

[WPF DataGrid](https://www.syncfusion.com/wpf-ui-controls/datagrid) (SfDataGrid) is bound to a collection with a class type. You can bind a list of string as an ItemsSource of SfDataGrid can be achieved by using [GridTemplateColumn](https://help.syncfusion.com/cr/cref_files/xamarin/Syncfusion.SfDataGrid.XForms~Syncfusion.SfDataGrid.XForms.GridTemplateColumn.html).

```c#
public class ViewModel
{
    public ViewModel()
    {
        this.DataFieldList = new List<string>() { "Item1", "Item2" , "Item3", "Item4", "Item5", "Item6", "Item7", "Item8", "Item9", "Item10" };
    }

    public List<string> DataFieldList
    {
        get;
        set;
    }
}
```
```xml
<Window.DataContext>
    <local:ViewModel />
</Window.DataContext>
<Grid>
    <syncfusion:SfDataGrid Name="dataGrid"
                            AllowFiltering="False"
                            AllowResizingColumns="False"
                            AutoGenerateColumns="False"
                            ColumnSizer="Star"
                            NavigationMode="Row"
                            ItemsSource="{Binding DataFieldList, UpdateSourceTrigger=PropertyChanged}">
        <syncfusion:SfDataGrid.Columns>
            <syncfusion:GridTemplateColumn HeaderText="Column Name" >
                <syncfusion:GridTemplateColumn.CellTemplate>
                    <DataTemplate>
                        <TextBlock Text="{Binding}" />
                    </DataTemplate>
                </syncfusion:GridTemplateColumn.CellTemplate>
            </syncfusion:GridTemplateColumn>
        </syncfusion:SfDataGrid.Columns>
    </syncfusion:SfDataGrid>
</Grid>
```

KB article - [How to bind the list of string to WPF DataGrid(SfDataGrid)?](https://www.syncfusion.com/kb/11357/how-to-bind-the-list-of-string-to-wpf-datagrid-sfdatagrid)

## Requirements to run the demo
Visual Studio 2015 and above versions
