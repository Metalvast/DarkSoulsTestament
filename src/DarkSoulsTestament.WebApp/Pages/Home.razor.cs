using Microsoft.AspNetCore.Components;
using System.Collections.Immutable;

namespace DarkSoulsTestament.WebApp.Pages;

public partial class Home
{
    private static readonly ImmutableList<MarkupString> _oneToFiveTestaments = new List<MarkupString>
    {
        new("1. Запрещён перекач"),
        new("2. Запрещены суммоны<br /> (Даже если очень тяжело)"),
        new("3. Запрещён мультиплеер"),
        new("4. Запрещено смотреть <br /> подсказки разраба"),
        new("5. Запрещены дамажущая <br /> магия/чудеса/пиромантия")
    }.ToImmutableList();

    private static readonly ImmutableList<MarkupString> _sixToTenTestaments = new List<MarkupString>
    {
        new("6. Запрещены подсказки<br />смотрящих"),
        new("7. Дай ближнему своему,<br />за пару уровней,<br />совет"),
        new("8. Запрещены ковенанты <br />(кроме ковенанта Чемпионов)"),
        new("9. Запрещено гуглить"),
        new("10. Не поддаваться баго-юзу")
    }.ToImmutableList();
}
