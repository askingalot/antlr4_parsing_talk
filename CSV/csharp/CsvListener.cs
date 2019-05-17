using System;
using System.Collections.Generic;
using System.Linq;

class CsvListener : CSVBaseListener
{

    public List<Dictionary<string, string>> Records { get; }
        = new List<Dictionary<string, string>>();

    public List<String> Header { get; } = new List<string>();

    private bool _isHeader = true;

    public override void ExitHdr(CSVParser.HdrContext context)
    {
        _isHeader = false;
    }

    public override void EnterRow(CSVParser.RowContext context)
    {
        if (_isHeader) return;
        Records.Add(new Dictionary<string, string>());
    }

    public override void ExitField(CSVParser.FieldContext context) {
        var content = context.GetText();
        if (_isHeader) {
            Header.Add(content);
        } else {
            var col = Records.Last().Count;
            Records.Last().Add(Header[col], content);
        }
    }
}