using NodeCanvas.Framework;
using ParadoxNotion.Design;


namespace NodeCanvas.Tasks.Conditions{

	[Category("ZFCategory")]
	[Description("ZFDescription")]
	public class MyFirstCondition : ConditionTask{

		protected override string OnInit(){
			return null;
		}

		protected override bool OnCheck(){
			return true;
		}
	}
}