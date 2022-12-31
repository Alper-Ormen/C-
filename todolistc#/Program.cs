List<Todo> todoList = new List<Todo>();
string select;

while (true)
{
    Console.WriteLine("Yapmak istediğiniz işlemi seçin: \n[0] Çıkış \n[1] Listele \n[2] Ekle \n[3] Düzenle \n[4] Sil");
    select = Console.ReadLine()!;
    switch (select)
    {
        case "0":
            cikis();
            break;
        case "1":
            listele(todoList);
            break;
        case "2":
            ekle();
            break;
        case "3":
            guncelle();
            break;
        case "4":
            sil();
            break;
        default:
            Console.WriteLine("0-4 arasında bir değer giriniz");
            break;
    }
}
void cikis()
{
    Console.WriteLine("Çıkmak istediğinize emin misiniz? E veya H deyin.");
    string onExit = Console.ReadLine()!;
    if (onExit.ToLower() == "e")
    {
        Console.WriteLine("Güle güle...");
        Environment.Exit(0);
    }
    else
    {
        Console.WriteLine("Çıkış işlemi iptal edildi.");
    } // bu kadar....
}
void ekle()
{
    int id;
    string _title;
    Console.Write("Başlık: ");
    _title = Console.ReadLine()!;
    if (todoList.Count() > 0)
    {
        id = (int)(todoList.Last().id + 1);
    }
    else
    {
        id = 1;
    }
    Todo todo = new Todo(id, _title, false);
    todoList.Add(todo);
    Console.WriteLine("Kaydınız Başarıyla Eklendi");
}

void listele(List<Todo> todoList)
{

    if (todoList.Count() > 0)
    {
        Console.WriteLine("ID\tName\t\tYapıldı mı?");

        foreach (var item in todoList)
        {
            Console.WriteLine("{0}\t{1}\t\t{2}", item.id, item.title, item.isComplated == true ? "Yapıldı" : "Yapılmadı");

        }
    }
    else
    {
        Console.WriteLine("Kayıt Bulunamadı");
    }
}

void guncelle()
{
    Console.WriteLine("ID Gir: ");
    int id = int.Parse(Console.ReadLine()!);
    Todo todo = todoList.Find(x => x.id == id)!;
    if (todo == null)
    {
        Console.WriteLine("Kayıt bulunamadı");
    }
    else
    {
        Console.WriteLine("Yeni title'ı gir: ");
        string newTitle = Console.ReadLine()!;
        Console.WriteLine("Yapıldı mı? E veya H yazın.");
        string complated = Console.ReadLine()!;
        bool isComplated = complated.ToLower() == "E" ? true : false;
        todo.title = newTitle;
        todo.isComplated = isComplated;
        Console.WriteLine("Kaydınız Başarıyla Değiştirildi");

    }
}



void sil()
{
    Console.WriteLine("ID Gir: ");
    int id = int.Parse(Console.ReadLine()!);
    Todo item = todoList.Find(x => x.id == id)!;
    if (item == null)
    {
        Console.WriteLine("Kayıt bulunamadı");
    }
    else
    {
        todoList.Remove(item);
        Console.WriteLine("Kaydınız Başarıyla Silindi");

    }
}