Console.WriteLine("PriorityQueue");

// var queue = new PriorityQueue<string, int>();
// queue.Enqueue("Item 1", 0);
// queue.Enqueue("Item 2", 4);
// queue.Enqueue("Item 3", 2);
// queue.Enqueue("Item 4", 1);

// while (queue.TryDequeue(
//   out var item,
//   out var priority
// ))
// {
//   Console.WriteLine($"Item: {item}. Priority: {priority}");
// }

var queue = new PriorityQueue<Student, string>(new RoleComparer());
queue.Enqueue(new Student("Spiderman"), "student");
queue.Enqueue(new Student("Ironman"), "premium");
queue.Enqueue(new Student("Batman"), "admin");

while (queue.TryDequeue(
  out var item,
  out var priority
))
{
  Console.WriteLine($"Item: {item.name}. Priority: {priority}");
}

public record Student(string name);

public class RoleComparer : IComparer<string>
{
  public int Compare(string? roleA, string? roleB)
  {
    if (roleA == roleB)
      return 0;

    return roleA switch
    {
      "admin" => -1,
      "premium" => -1,
      _ => 1
    };
  }
}