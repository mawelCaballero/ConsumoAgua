namespace ConsumoAgua.Models
{
    public enum MenuItemType
    {
        ContadorAgua,
        AcercaDe,
        Estadisticas

    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
