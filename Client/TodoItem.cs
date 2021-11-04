public class TodoItem
{ //creates a class for itemizing the Todo list per item

    public string Title { get; set; } //Title is a property | get & set are the methods
                                      //a property is kind of like a field, or kind of like a method
                                      // This allows for the inputted text of said item Todo
    public bool IsDone { get; set; } // This allows for the check off once complete
}