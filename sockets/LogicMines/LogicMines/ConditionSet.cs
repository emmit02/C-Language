using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;

public enum Variable
{
    BID_PRICE,
    BID_QTY,
    ASK_PRICE,
    ASK_QTY
}

public enum Operation
{
    GT,
    LT,
    EQ
}

[Serializable]
public class Condition
{
    public Variable Var1 { get; set; }
    public bool IsValue { get; set; }
    public Variable Var2 { get; set; }
    public float Value { get; set; }
    public Operation Op { get; set; }
}

[Serializable]
public class ConditionSet
{
    public List<Condition> Conditions { get; set; } = new List<Condition>();
}
