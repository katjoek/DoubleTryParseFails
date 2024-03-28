using System.Globalization;

namespace DoubleTryParseFails;

public class DoubleTryParseTests
{
    [Fact]
    public void This_test_fails_unexpectedly()
    {
        var value = 2000.0;
        var valueAsText = value.ToString("N5", CultureInfo.CurrentCulture); // 2,000.00000
        var success = double.TryParse(valueAsText, NumberStyles.Any, CultureInfo.CurrentCulture, out value);
        Assert.True(success);
    }
    
    [Fact]
    public void This_works_as_expected()
    {
        var value = 2000.0;
        var valueAsText = value.ToString("F5", CultureInfo.CurrentCulture); // 2000.00000
        var success = double.TryParse(valueAsText, NumberStyles.Any, CultureInfo.CurrentCulture, out value);
        Assert.True(success);
    }
}