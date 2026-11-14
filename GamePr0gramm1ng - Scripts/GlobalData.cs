public class GlobalData // класс данных доступный из любого скрипта в проекте
{
    private static GlobalData instance = null; // ссылка на экземпл€р класса
    public static GlobalData SharedInstance // метод доступа к классу
    {
        get
        {
            if (instance == null) // если объект класса не существует
            {
                instance = new GlobalData(); // создать объект
            }
            return instance; // вернуть ссылку на объект
        }
    }
    public int data = 2; // поле хран€щее данные
    public int maxLvl = 2;
}
