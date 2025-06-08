namespace Creational.Prototype;

public class AndroidModel(int id, string name, string model, string os, string cpu, string gpu)
{
    public int Id { get; set; } = id;
    public string Name { get; set; } = name;
    public string Model { get; set; } = model;
    public string Os { get; set; } = os;
    public string Cpu { get; set; } = cpu;
    public string Gpu { get; set; } = gpu;

    public override string ToString()
    {
        return $"Id: {Id}, Name: {Name}, Model: {Model}, OS: {Os}, CPU: {Cpu}, GPU: {Gpu}";
    }
}