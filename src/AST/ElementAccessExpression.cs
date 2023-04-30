using Gaia.Domain;

namespace Gaia.AST;

public class ElementAccessExpression : Expression {
    /// <summary>
    /// primitive type or array type
    /// </summary>
    public Expression Expression { get; }
    /// <summary>
    /// index
    /// </summary>
    public Expression ArgumentExpression { get; }

    public ElementAccessExpression(Expression expr, Expression argumentExpression) {
        Expression = expr;
        ArgumentExpression = argumentExpression;
    }

    public SyntaxKind Kind { get; }

    public TResult Accept<TResult, TContext>(Visitor<TResult, TContext> v, TContext ctx) {
        return v.Visit(this, ctx);
    }
}
