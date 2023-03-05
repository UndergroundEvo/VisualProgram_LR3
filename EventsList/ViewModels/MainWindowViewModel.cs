using EventsList.Models;

namespace EventsList.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        readonly CityEventCategory[] cityEventCategories = new CityEventCategory[]
        {
            new CityEventCategory("��� �����", "Assets/Images/Header/Children.png", "Children"),
            new CityEventCategory("�����", "Assets/Images/Header/Sport.png", "Sport"),
            new CityEventCategory("��������", "Assets/Images/Header/Culture.png", "Culture"),
            new CityEventCategory("���������", "Assets/Images/Header/Excursion.png", "Excursion"),
            new CityEventCategory("����� �����", "Assets/Images/Header/Lifestyle.png", "Lifestyle"),
            new CityEventCategory("���������", "Assets/Images/Header/Party.png", "Party"),
            new CityEventCategory("�����������", "Assets/Images/Header/Education.png", "Education"),
            new CityEventCategory("������", "Assets/Images/Header/Online.png", "Online"),
            new CityEventCategory("���", "Assets/Images/Header/Show.png", "Show"),
        };
        public CityEventCategory[] CityEventCategories { get => cityEventCategories; }
    }
}