using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enigma.D3.Enums;
using Enigma.D3.Helpers;
using Enigma.D3.Sno;
using Enigma.Memory;

namespace Enigma.D3.Sno
{
	public static class SnoHelper
	{
		public static IEnumerable<T> Enumerate<T>(SnoGroupId groupId) where T : SerializeMemoryObject
		{
			var container = Engine.TryGet((engine) => engine.SnoGroupsByCode[(int)groupId].x10_Container);
			if (container == null)
				return Enumerable.Empty<T>();

			return container
				.Where(a=>a.x00_Id != -1)
				.Where(a => a.x07_SnoGroupId == (byte)groupId)
				.Select(a => a.x0C_Ptr_SnoValue.Cast<T>().Dereference());
		}

		public static T GetSnoValue<T>(SnoGroupId groupId, int snoId) where T: SerializeMemoryObject
		{
			var container = Engine.TryGet((engine) => engine.SnoGroupsByCode[(int)groupId].x10_Container);
			if (container == null)
				return default(T);

			var def = container.x11C_Ptr_Items.Cast<SnoDefinition<T>>()[(short)SnoIdToEntityId(snoId)];
			return def.x0C_Ptr_SnoValue.Dereference();
		}

		public static int SnoIdToEntityId(int snoId)
		{
			return Engine.Current.Memory.Reader.Read<Ptr<int>>(0x01C634E0)[snoId];
		}

		public static SnoFile<T> LoadFile<T>(string path) where T : SerializeMemoryObject
		{
			var buffer = new BufferMemoryReader(File.ReadAllBytes(path));
			var file = buffer.Read<SnoFile<T>>(0x00);
			if (!file.Header.IsValid)
				throw new InvalidDataException("Invalid header bytes.");
			return file;
		}

		public static string GetSlug(SnoGroupId groupId, int snoId)
		{
			var map = SnoFiles.Instance.x09F8_SnoFileMaps[(int)groupId];
			return map.GetValue(snoId, HashUtils.Fnv32).Dereference().x00_Slug.ToString();
		}
	}
}
