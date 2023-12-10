using Microsoft.AspNetCore.Components;

namespace desafio.Components.Pages;

public class CounterCode: ComponentBase
{

    protected int currentCount = 0;
    protected string _text = "";

    protected void IncrementCount()
    {
        currentCount++;
    }

}