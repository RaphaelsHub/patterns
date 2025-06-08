namespace Creational.Prototype;

public class AndroidRobot : IPrototype<AndroidRobot>
{
    private AndroidModel _data;

    public AndroidRobot(AndroidModel data) => _data = data;
    public void SetData(AndroidModel data) => _data = data;


    public AndroidRobot Clone() => new AndroidRobot(this._data);
    public override string ToString() => _data.ToString();
}