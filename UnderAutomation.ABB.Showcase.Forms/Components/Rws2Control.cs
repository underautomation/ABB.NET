using System.ComponentModel;
using UnderAutomation.ABB;
using UnderAutomation.ABB.Rws;

public partial class Rws2Control : UserControl, IUserControl
{
    private readonly AbbController _robot;

    public Rws2Control(AbbController robot)
    {
        _robot = robot;
        InitializeComponent();
    }

    #region IUserControl

    public string Title => "RWS";

    public bool FeatureEnabled => _robot.Rws != null;

    public void PeriodicUpdate() { }

    public void OnOpen() { }

    public void OnClose() { }

    #endregion

    #region Helpers

    [TypeConverterAttribute(typeof(ObjectConverter))]
    public class Wrapper
    {
        public object Result { get; set; }
    }

    private void Execute(Func<object?> action)
    {
        try
        {
            Cursor = Cursors.WaitCursor;
            pgAnswer.ViewForeColor = Color.Black;
            var result = action();

            if (result != null)
            {
                var type = result.GetType();
                var elementType = type.GetElementType();
                if (elementType != null) type = elementType;

                if (!type.IsClass || (type == typeof(string) && elementType == null))
                {
                    result = new { Result = result };
                }
                else if (!TypeDescriptor.GetAttributes(type).OfType<TypeConverterAttribute>().Any())
                {
                    TypeDescriptor.AddAttributes(type, new TypeConverterAttribute(typeof(ObjectConverter)));
                }
            }

            pgAnswer.SelectedObject = result;
            pgAnswer.ExpandAllGridItems();
        }
        catch (Exception ex)
        {
            pgAnswer.ViewForeColor = Color.DarkRed;
            pgAnswer.SelectedObject = ex;
        }
        finally
        {
            Cursor = Cursors.Default;
        }
    }

    private void Execute(Action action)
    {
        Execute(() => { action(); return "OK"; });
    }

    /// <summary>Parse "key=val;key2=val2" into a dictionary</summary>
    private Dictionary<string, string> ParseKeyValuePairs(string input)
    {
        var dict = new Dictionary<string, string>();
        if (string.IsNullOrWhiteSpace(input)) return dict;
        foreach (var pair in input.Split(';'))
        {
            var idx = pair.IndexOf('=');
            if (idx > 0)
                dict[pair.Substring(0, idx).Trim()] = pair.Substring(idx + 1).Trim();
        }
        return dict;
    }

    #endregion

}
