﻿namespace Lab5.Expressions;

public class StringExpression : AbstractExpression
{
    private string _value;

    public StringExpression(string value)
    {
        _value = value;
    }

    public override object Interpret(Context context)
    {
        return _value;
    }

    public override string ToString()
    {
        return _value;
    }
}