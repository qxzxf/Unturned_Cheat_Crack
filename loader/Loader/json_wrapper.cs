using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;

// Token: 0x0200000E RID: 14
public class json_wrapper
{
	// Token: 0x0600008D RID: 141 RVA: 0x0000684C File Offset: 0x00004A4C
	public static bool TranslateBroadcastReload(Type to_check)
	{
		int num = 0;
		do
		{
			if (num == 1)
			{
				if (to_check.IsSerializable)
				{
					goto IL_89;
				}
				num = 2;
			}
			if (num == 0)
			{
				num = 1;
			}
		}
		while (num != 2);
		return to_check.IsDefined(typeof(DataContractAttribute), <Module>.R2V0UGVybWlzc2lvbnM=c2V0X0hlYWRsaW5l != 0);
		IL_89:
		return <Module>.R2V0UGVybWlzc2lvbnM=c2V0X0hlYWRsaW5l != 0;
	}

	// Token: 0x0600008E RID: 142 RVA: 0x000068E8 File Offset: 0x00004AE8
	public json_wrapper(object obj_to_work_with)
	{
		this.current_object = obj_to_work_with;
		Type type = this.current_object.GetType();
		this.serializer = new DataContractJsonSerializer(type);
		bool flag = !json_wrapper.TranslateBroadcastReload(type);
		if (flag)
		{
			throw new Exception(string.Format("the object {0} isn't a serializable", this.current_object));
		}
	}

	// Token: 0x0600008F RID: 143 RVA: 0x00006940 File Offset: 0x00004B40
	public object get_Syntax<Awake>b__8_0get_Name(string json)
	{
		byte[] bytes = Encoding.Default.GetBytes(json);
		object result;
		using (MemoryStream memoryStream = new MemoryStream(bytes))
		{
			result = this.serializer.ReadObject(memoryStream);
		}
		return result;
	}

	// Token: 0x06000090 RID: 144 RVA: 0x0000698C File Offset: 0x00004B8C
	public T ReloadSetCooldownTryInvoke<T>(string json)
	{
		int num = 0;
		do
		{
			if (num == 0)
			{
				num = 1;
			}
		}
		while (num != 1);
		return (T)((object)this.get_Syntax<Awake>b__8_0get_Name(json));
	}

	// Token: 0x04000099 RID: 153
	private DataContractJsonSerializer serializer;

	// Token: 0x0400009A RID: 154
	private object current_object;
}
