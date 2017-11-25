using NodeCanvas.Framework;
using ParadoxNotion.Design;


namespace UnityGame{

	[Category("ZFCategory")]
	[Description("ZFDescription")]
	public class MyFirstAction : ActionTask{

		[BlackboardOnly]
		public BBParameter<float> waitTime;
		protected override string OnInit(){
			return null;
		}

		protected override void OnExecute(){
			if(elapsedTime > waitTime.value)
				EndAction(true);
		}

		protected override void OnUpdate(){
			
		}

		protected override void OnStop(){
			
		}

		protected override void OnPause(){
			
		}
	}
}