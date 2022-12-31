internal class Todo
{
       public int? id { get; set; }
    public string? title { get; set; }
    public bool? isComplated { get; set; }

    public Todo(int id,string title,bool isComplatte){
        this.id=id;
         this.title=title;
          this.isComplated=isComplated;
    }
}