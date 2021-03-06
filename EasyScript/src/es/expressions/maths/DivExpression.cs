using Engine.Bases;

namespace Easily.ES {

/// <summary>
/// @author Easily
/// </summary>
public class DivExpression : MathExpression {

	public DivExpression(IRightExpression value1, IRightExpression value2) : base(value1, value2) {
		// ignored
	}

	public override IESObject GetValue(ESDomain domain) {
		var v1 = _value1.GetValue<IESNumber>(domain);
		var v2 = _value2.GetValue<IESNumber>(domain);
		return new ESNumber(v1.Value / v2.Value);
	}

}

}