using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Newtonsoft.Json;

#pragma warning disable CA1819 // Properties should not return arrays
namespace pkNX.Structures
{
    public static class Xzonn
    {
        public static string[] TRType = new string[] { "一般", "一般", "火", "水", "水", "冰", "冰", "格斗", "电", "电", "地面", "超能力", "超能力", "一般", "一般", "火", "水", "超能力", "虫", "一般", "一般", "格斗", "毒", "地面", "龙", "超能力", "一般", "一般", "虫", "一般", "一般", "钢", "恶", "幽灵", "超能力", "一般", "火", "恶", "超能力", "格斗", "超能力", "火", "一般", "火", "超能力", "水", "钢", "龙", "格斗", "超能力", "草", "龙", "钢", "格斗", "毒", "火", "格斗", "毒", "恶", "草", "虫", "虫", "龙", "岩石", "格斗", "草", "飞行", "地面", "恶", "超能力", "钢", "草", "草", "毒", "钢", "岩石", "岩石", "草", "毒", "钢", "电", "恶", "超能力", "超能力", "水", "一般", "电", "地面", "火", "飞行", "妖精", "毒", "妖精", "恶", "地面", "恶", "虫", "超能力", "水", "格斗" };
        public static int SortNest(EncounterNest8 x, EncounterNest8 y)
        {
            if (x.FlawlessIVs != y.FlawlessIVs)
            {
                return x.FlawlessIVs < y.FlawlessIVs ? -1 : 1;
            }
            else if (x.DropTableID != y.DropTableID)
            {
                return x.DropTableID < y.DropTableID ? -1 : 1;
            }
            else if (x.BonusTableID != y.BonusTableID)
            {
                return x.BonusTableID < y.BonusTableID ? -1 : 1;
            }
            else
            {
                int j;
                for (j = 0; j < 5; j++)
                {
                    if (x.Probabilities[j] != y.Probabilities[j])
                    {
                        return x.Probabilities[j] < y.Probabilities[j] ? 1 : -1;
                    }
                }
                if (j == 5)
                {
                    if (x.Species != y.Species)
                    {
                        return x.Species < y.Species ? -1 : 1;
                    }
                    else if (x.AltForm != y.AltForm)
                    {
                        return x.AltForm < y.AltForm ? -1 : 1;
                    }
                    else if (x.IsGigantamax != y.IsGigantamax)
                    {
                        return x.IsGigantamax ? -1 : 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
                return 0;
            }
        }
        public static string Form(int id)
        {
            switch (id)
            {
                case 201: return "A";
                case 386: return "普通形态";
                case 412: return "草木蓑衣";
                case 413: return "草木蓑衣";
                case 421: return "阴天形态";
                case 422: return "西海";
                case 423: return "西海";
                case 487: return "别种形态";
                case 492: return "陆上形态";
                case 550: return "红条纹";
                case 555: return "普通模式";
                case 585: return "春天";
                case 586: return "春天";
                case 641: return "化身形态";
                case 642: return "化身形态";
                case 645: return "化身形态";
                case 647: return "平常";
                case 648: return "歌声形态";
                case 666: return "冰雪花纹";
                case 669: return "红花";
                case 670: return "红花";
                case 671: return "红花";
                case 676: return "野生";
                case 678: return "雄性";
                case 681: return "盾牌形态";
                case 710: return "普通尺寸";
                case 711: return "普通尺寸";
                case 716: return "放松模式";
                case 718: return "５０％形态";
                case 720: return "惩戒胡帕";
                case 741: return "热辣热辣风格";
                case 745: return "白昼";
                case 746: return "单独";
                case 773: return "属性：一般";
                case 774: return "流星";
                case 778: return "化形";
                case 849: return "高调";
                case 869: return "奶香香草";
                case 875: return "结冻头";
                case 876: return "雄性";
                case 877: return "满腹花纹";
                case 888: return "百战勇者";
                case 889: return "百战勇者";
                case 892: return "一击流";
                case 896: return "初始帽子";
                case 897: return "丰缘帽子";
                case 898: return "神奥帽子";
                case 899: return "合众帽子";
                case 900: return "卡洛斯帽子";
                case 901: return "阿罗拉帽子";
                case 902: return "就决定是你了之帽子";
                case 904: return "世界帽子";
                case 905: return "阿罗拉";
                case 906: return "阿罗拉";
                case 907: return "阿罗拉";
                case 908: return "阿罗拉";
                case 909: return "阿罗拉";
                case 910: return "阿罗拉";
                case 911: return "阿罗拉";
                case 912: return "阿罗拉";
                case 913: return "伽勒尔";
                case 914: return "阿罗拉";
                case 918: return "伽勒尔";
                case 919: return "伽勒尔";
                case 920: return "伽勒尔";
                case 922: return "伽勒尔";
                case 923: return "伽勒尔";
                case 926: return "阿罗拉";
                case 927: return "阿罗拉";
                case 928: return "伽勒尔";
                case 929: return "伽勒尔";
                case 957: return "伽勒尔";
                case 958: return "伽勒尔";
                case 959: return "伽勒尔";
                case 973: return "晴天";
                case 974: return "东海";
                case 975: return "东海";
                case 976: return "加热洛托姆";
                case 977: return "清洗洛托姆";
                case 978: return "结冰洛托姆";
                case 979: return "旋转洛托姆";
                case 980: return "切割洛托姆";
                case 1000: return "蓝条纹";
                case 1001: return "达摩模式";
                case 1002: return "达摩模式";
                case 1003: return "伽勒尔";
                case 1004: return "伽勒尔达摩模式";
                case 1005: return "伽勒尔";
                case 1012: return "伽勒尔";
                case 1016: return "焰白酋雷姆";
                case 1017: return "暗黑酋雷姆";
                case 1018: return "觉悟的样子";
                case 1105: return "雌性";
                case 1106: return "刀剑形态";
                case 1107: return "小尺寸";
                case 1108: return "大尺寸";
                case 1109: return "特大尺寸";
                case 1110: return "小尺寸";
                case 1111: return "大尺寸";
                case 1112: return "特大尺寸";
                case 1122: return "特殊岩狗狗";
                case 1123: return "黑夜";
                case 1124: return "黄昏";
                case 1125: return "鱼群";
                case 1126: return "格斗";
                case 1127: return "飞行";
                case 1128: return "毒";
                case 1129: return "地面";
                case 1130: return "岩石";
                case 1131: return "虫";
                case 1132: return "幽灵";
                case 1133: return "钢";
                case 1134: return "火";
                case 1135: return "水";
                case 1136: return "草";
                case 1137: return "电";
                case 1138: return "超能力";
                case 1139: return "冰";
                case 1140: return "龙";
                case 1141: return "恶";
                case 1142: return "妖精";
                case 1156: return "现形";
                case 1157: return "黄昏之鬃";
                case 1158: return "拂晓之翼";
                case 1159: return "５００年前";
                case 1160: return "一口吞";
                case 1161: return "大口吞";
                case 1162: return "低调";
                case 1163: return "";
                case 1164: return "";
                case 1165: return "奶香红钻";
                case 1166: return "奶香抹茶";
                case 1167: return "奶香薄荷";
                case 1168: return "奶香柠檬";
                case 1169: return "奶香雪盐";
                case 1170: return "红钻综合";
                case 1171: return "焦糖综合";
                case 1172: return "三色综合";
                case 1173: return "解冻头";
                case 1174: return "雌性";
                case 1175: return "空腹花纹";
                case 1176: return "剑之王";
                case 1177: return "盾之王";
                case 1178: return "无极巨化";
                case 1179: return "连击流";
                case 1180: return "阿爸";
                default: return string.Empty;
            }
        }
    }

    public class EncounterNest8Archive
    {
        public EncounterNest8Table[] Tables { get; set; }
    }

    public class EncounterNest8Table
    {
        public ulong TableID { get; set; }
        public int GameVersion { get; set; }
        public EncounterNest8[] Entries { get; set; }

        public string GetSummarySimple()
        {
            var tableID = TableID.ToString("X16");
            var tableData = TableUtil.GetTable(Entries);

            return tableID + Environment.NewLine + tableData + Environment.NewLine;
        }

        public IEnumerable<string> GetSummary(IReadOnlyList<string> species, int index)
        {
            foreach (var entry in Entries)
                foreach (var summary in Summary(entry))
                    yield return summary;
            yield return string.Empty;

            IEnumerable<string> Summary(EncounterNest8 e)
            {
                var comment = $" // {species[e.Species]}{(e.AltForm == 0 ? string.Empty : "-" + e.AltForm)}";
                var gender = e.Gender == 0 ? string.Empty : $", Gender = {e.Gender - 1}";
                var altform = e.AltForm == 0 ? string.Empty : $", Form = {e.AltForm}";
                var giga = !e.IsGigantamax ? string.Empty : ", CanGigantamax = true";
                var ability = e.Ability switch
                {
                    2 => "A2",
                    3 => "A3",
                    4 => "A4",
                    _ => throw new Exception()
                };
                var flawless = e.FlawlessIVs;

                // calc min/max ranks
                int min = e.MinRank;
                int max = e.MaxRank;

                int curMin = -1;
                for (int i = min; i < max; i++)
                {
                    if (e.Probabilities[i] != 0)
                    {
                        if (curMin == -1)
                            curMin = i;

                        if (i == max - 1)
                            yield return $"            new EncounterStatic8N(Nest{index:00},{curMin},{i},{flawless}) {{ Species = {e.Species:000}, Ability = {ability}{gender}{altform}{giga} }},{comment}";
                    }
                    else if (curMin != -1)
                    {
                        yield return $"            new EncounterStatic8N(Nest{index:00},{curMin},{i - 1},{flawless}) {{ Species = {e.Species:000}, Ability = {ability}{gender}{altform}{giga} }},{comment}";
                        curMin = -1;
                    }
                }
            }
        }

        public IEnumerable<string> GetPrettySummary(IReadOnlyList<string> species, IReadOnlyList<string> items, IReadOnlyList<string> moves, IReadOnlyList<int> tmtrs,
            IReadOnlyList<NestHoleReward8Table> drop_tables, IReadOnlyList<NestHoleReward8Table> bonus_tables, int index, PersonalTable pt = null, string[] types = null)
        {
            //yield return $"Nest ID: {TableID:X4}";
            Debug.WriteLine(index);

            yield return "{{捕捉/header/巢穴2|" + (GameVersion == 1 ? "SW" : "SH") + "}}";
            yield return $"|-\n| colspan=\"11\" class=\"bgwhite\" | Nest ID: {TableID:X4}";
            List<EncounterNest8> sortedEntries = Entries.ToList();
            sortedEntries.Sort(Xzonn.SortNest);
            List<EncounterNest8> table = new List<EncounterNest8> { sortedEntries[0] };
            uint[] Probabilities = new uint[] { 0, 0, 0, 0, 0 };
            int i, j;
            for (i = 1; i < sortedEntries.Count; i++)
            {
                if (sortedEntries[i].Species == sortedEntries[i - 1].Species && sortedEntries[i].AltForm == sortedEntries[i - 1].AltForm && sortedEntries[i].IsGigantamax == sortedEntries[i - 1].IsGigantamax && sortedEntries[i].FlawlessIVs == sortedEntries[i - 1].FlawlessIVs && sortedEntries[i].DropTableID == sortedEntries[i - 1].DropTableID)
                {
                    for (j = 0; j < 5; j++)
                    {
                        table[table.Count - 1].Probabilities[j] += sortedEntries[i].Probabilities[j];
                    }
                }
                else
                {
                    table.Add(sortedEntries[i]);
                }
            }
            table.Sort(Xzonn.SortNest);
            for (i = 0; i < table.Count; i++)
            {
                foreach (var line in PrettySummary(table[i], table.ToArray(), i, pt, types))
                    yield return $"{line}";
            }
            yield return "{{捕捉/footer/巢穴2|" + (GameVersion == 1 ? "SW" : "SH") + "}}";

            /*
            foreach (var entry in Entries)
            {
                foreach (var line in PrettySummary(entry))
                    yield return $"\t{line}";
            }*/

            yield return string.Empty;

            IEnumerable<string> PrettySummary(EncounterNest8 e, EncounterNest8[] table = null, int count = 0, PersonalTable pt = null, string[] types = null)
            {
                var game = GameVersion switch
                {
                    1 => "yes|no",
                    2 => "no|yes",
                    _ => throw new NotImplementedException()
                };
                int formNum = pt.GetFormeIndex(e.Species, e.AltForm);
                var giga = e.IsGigantamax ? "超极巨化" : string.Empty;
                var form = e.AltForm != 0 ? $"-{e.AltForm}" : string.Empty;
                string xzForm = Xzonn.Form(formNum);
                string xzFormOut = (xzForm + giga).Length > 0 ? "|form=" + xzForm + giga : "";
                string type = $"|type1={types[pt[formNum].Type1]}" + (pt[formNum].Type1 != pt[formNum].Type2 ? $"|type2={types[pt[formNum].Type2]}" : "");
                var rank = $"{e.MinRank + 1}-Star";
                string ret = "{{捕捉/entry8/巢穴2|" + $"{e.Species:D3}{xzFormOut}|{species[e.Species]}{type}|{game}|";
                //yield return "{{" + $"" + "}}";
                //yield return $"{rank} {giga}{e.Species}-{e.AltForm} {species[e.Species]}";
                //yield return $"\tLv. {15 + (10 * e.MinRank)}-{20 + (10 * e.MaxRank)}";
                //yield return $"\tGender: {new[] { "Random", "Male", "Female", "Genderless" }[e.Gender]}";

                var ability = e.Ability switch
                {
                    2 => "100",
                    3 => "no",
                    4 => "yes",
                    _ => throw new Exception()
                };
                //yield return $"\tAbility: {ability}";
                //yield return "\tSelection Probabilities:";
                for (var i = 0; i < e.Probabilities.Length; i++)
                {
                    if (e.Probabilities[i] != 0)
                    {
                        ret += $"{e.Probabilities[i]}";
                        //yield return $"\t\t{i + 1}-Star Desired: {e.Probabilities[i]:00}%";
                    }
                    ret += "|";
                }
                ret += $"{ability}|";

                if (count == 0 || table[count - 1].FlawlessIVs != e.FlawlessIVs || table[count - 1].DropTableID != e.DropTableID || table[count - 1].BonusTableID != e.BonusTableID)
                {
                    //yield return "\tBonus Drops:";
                    foreach (var entry in GetOrderedDrops(bonus_tables, e.BonusTableID, e.FlawlessIVs))
                    {
                        ret += $"{GetItemName(entry.ItemID)}×{entry.Values[e.FlawlessIVs]}<br>";
                        //yield return $"\t\t{entry.Values[e.FlawlessIVs]} x {GetItemName(entry.ItemID)}";
                    }
                    ret = ret.Substring(0, ret.Length - 4) + "<hr>";

                    //yield return "\tDrops:";
                    foreach (var entry in GetOrderedDrops(drop_tables, e.DropTableID, e.FlawlessIVs))
                    {
                        ret += $"{GetItemName(entry.ItemID)} {entry.Values[e.FlawlessIVs]}%<br>";
                        //yield return $"\t\t{entry.Values[e.FlawlessIVs],3}% {GetItemName(entry.ItemID)}";
                    }
                    ret = ret.Substring(0, ret.Length - 4);
                    int j = 1;
                    while (count + j < table.Length && table[count + j].FlawlessIVs == e.FlawlessIVs && table[count + j].DropTableID == e.DropTableID && table[count + j].BonusTableID == e.BonusTableID)
                    {
                        j++;
                    }
                    ret += $"|{j}";
                }
                else
                {
                    ret += "|0";
                }
                ret += "}}";
                yield return ret;
                //yield return string.Empty;
            }

            IEnumerable<INestHoleReward> GetOrderedDrops(IReadOnlyList<INestHoleRewardTable> rewards, ulong tableID, int encounterRank)
            {
                var table = rewards.First(t => t.TableID == tableID);
                var list = table.Rewards
                    .Where(d => d.Values[encounterRank] != 0)
                    .OrderByDescending(d => d.Values[encounterRank])
                    .ThenBy(d => GetItemName(d.ItemID));

                foreach (var entry in list)
                    yield return entry;
            }

            string GetItemName(uint itemID)
            {
                if (1130 <= itemID && itemID < 1230)
                { // TR
                    return "{{bag|TR " + Xzonn.TRType[(int)itemID - 1130] + $"|baglink={items[(int)itemID]}" + "}}{{TR|" + $"{(int)itemID - 1130}" + "|8}}";
                    return $"{items[(int)itemID]} {moves[tmtrs[100 + (int)itemID - 1130]]}";
                }
                return "{{bag|" + items[(int)itemID] + "|show=y}}";
            }
        }
    }

    public class EncounterNest8
    {
        public int EntryIndex { get; set; }
        public int Species { get; set; }
        public int AltForm { get; set; }
        public ulong LevelTableID { get; set; }
        public byte Ability { get; set; }
        public bool IsGigantamax { get; set; }
        public ulong DropTableID { get; set; }
        public ulong BonusTableID { get; set; }
        public uint[] Probabilities { get; set; }
        public byte Gender { get; set; }
        public byte FlawlessIVs { get; set; }

        [JsonIgnore]
        public FixedAbility AbilityPermitted
        {
            get => (FixedAbility) Ability;
            set => Ability = (byte) value;
        }

        [JsonIgnore]
        public int MinRank => Array.FindIndex(Probabilities, z => z != 0);

        [JsonIgnore]
        public int MaxRank => Array.FindLastIndex(Probabilities, z => z != 0);

        public override string ToString() => $"{EntryIndex:00} - {Species:000}";
    }

    public enum FixedAbility
    {
        Ability1 = 0,
        Ability2 = 1,
        AbilityH = 2,
        Ability1_2 = 3,
        Any = 4,
    }
}
