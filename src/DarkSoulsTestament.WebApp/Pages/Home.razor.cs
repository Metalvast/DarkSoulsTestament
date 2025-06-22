using Microsoft.AspNetCore.Components;
using System.Collections.Immutable;

namespace DarkSoulsTestament.WebApp.Pages;

public partial class Home
{
    private static readonly ImmutableList<MarkupString> _oneToFiveTestaments = new List<MarkupString>
    {
        new("1. �������� �������"),
        new("2. ��������� �������"),
        new("3. �������� �����������"),
        new("4. ��������� �������� <br /> ��������� �������"),
        new("5. ��������� ��������� <br /> �����/������/����������")
    }.ToImmutableList();

    private static readonly ImmutableList<MarkupString> _sixToTenTestaments = new List<MarkupString>
    {
        new("6. ��������� ���������<br />���������"),
        new("7. ��� �������� ������,<br />�� ���� �������,<br />�����"),
        new("8. ��������� ��������� <br />(����� ��������� ���������)"),
        new("9. ��������� �������"),
        new("10. �� ����������� ����-���")
    }.ToImmutableList();
}
