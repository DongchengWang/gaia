﻿namespace Gaia.Inter;

using Gaia.Symbols;
using System.Collections.Generic;

public class Function : Stmt {
    public Id Name;
    public List<Id> Arguments;
    public Typ ReturnTyp;
    public Stmt Body;

    public Function(Id name, List<Id> args, Typ ret, Stmt body) {
        Name = name;
        Arguments = args;
        ReturnTyp = ret;
        Body = body;
    }
}
