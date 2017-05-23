using System.Collections.Generic;
namespace TodoList.Objects
{
  public class Task
  {
    private static List<string> _tasks = new List<string> {};
    private string _description;

    public Task(string description)
    {
      _description  = description;
    }
    public void SetDescription(string newDescription)
    {
      _description = newDescription;
    }
    public string GetDescription()
    {
      return _description;
    }
    public static List<string> GetAll()
    {
      return _tasks;
    }
    public void Save()
    {
      _tasks.Add(_description);
    }
  }
}
