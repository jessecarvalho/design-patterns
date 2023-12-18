namespace Factory.Interfaces;

public interface IFood
{
    string Name { get; }
    int Calories { get; }
    int Servings { get; }
    void Consume();
}