// Token: 0x02000010 RID: 16
public partial class Login : global::System.Windows.Forms.Form
{
	// Token: 0x060000AE RID: 174 RVA: 0x00008E00 File Offset: 0x00007000
	protected override void Dispose(bool disposing)
	{
		int num = 0;
		do
		{
			if (num == 1)
			{
				if (!disposing)
				{
					goto IL_79;
				}
				num = 2;
			}
			if (num == 0)
			{
				num = 1;
			}
		}
		while (num != 2);
		bool flag = this.components != null;
		goto IL_7E;
		IL_79:
		flag = (global::<Module>.c2V0X0Fzc2VtYmx5UGx1Z2luc19PblBsdWdpbnNMb2FkZWQ= != 0);
		IL_7E:
		bool flag2 = flag;
		bool flag3 = flag2;
		if (flag3)
		{
			this.components.Dispose();
		}
		base.Dispose(disposing);
	}

	// Token: 0x040000B3 RID: 179
	private global::System.ComponentModel.IContainer components = null;
}
