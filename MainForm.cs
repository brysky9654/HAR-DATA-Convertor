using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace HarParser
{
    public partial class MainForm : Form
    {
        private List<string> selectedFiles = new List<string>();
        private Dictionary<string, string> gameCodeDic = new Dictionary<string, string>
        {
            { "1067",   "Wanted Dead or a Wild" },
            { "1309",   "Le Bandit" },
            { "1538",   "Shadow Strike" },
            { "1233",   "Rip City" },
            { "1408",   "Fist of Destruction" },
            { "1482",   "Slayers INC" },
            { "1172",   "Dork Unit" },
            { "1508",   "Ze Zeus" },
            { "1164",   "Hand of Anubis" },
            { "1243",   "Stormforged" },
            { "1209",   "Rotten" },
            { "1434",   "Cursed Crypt" },
            { "1279",   "Beast Below" },
            { "1396",   "Xmas Drop" },
            { "1213",   "Book of Time" },
            { "1348",   "Densho" },
            { "1247",   "Magic Piggy" },
            { "1352",   "Chaos Crew II" },
            { "1490",   "Divine Drop" },
            { "1400",   "2 Wild 2 Die" },
            { "1526",   "Junkyard Kings" },
            { "1275",   "Mayan Stackways" },
            { "1456",   "Cash Crew" },
            { "1267",   "Ronin Stackways" },
            { "1364",   "Immortal Desire" },
            { "1404",   "Rusty & Curly" },
            { "1263",   "Cursed Seas" },
            { "1314",   "Drop'em" },
            { "1237",   "Temple of Torment" },
            { "1506",   "Barrel Bonanza" },
            { "1087",   "Toshi Video Club" },
            { "1193",   "Undead Fortune" },
            { "1168",   "Itero" },
            { "1356",   "Benny the Beer" },
            { "1217",   "Pug Life" },
            { "1426",   "Beam Boys�" },
            { "1452",   "Jelly Slice" },
            { "1392",   "Dark Summoning" },
            { "1344",   "Eye of the Panda" },
            { "1494",   "Keep 'em" },
            { "1160",   "Gladiator Legends" },
            { "1442",   "Dawn of Kings" },
            { "1084",   "Stack 'em" },
            { "1368",   "Fire Born" },
            { "1181",   "Time Spinners" },
            { "1225",   "Frank's Farm" },
            { "1524",   "Space Zoo" },
            { "1144",   "Double Rainbow" },
            { "1251",   "Bloodthirst" },
            { "1422",   "Bouncy Bombs" },
            { "1512",   "Wild Dojo Strike" },
            { "1083",   "Outlaws Inc" },
            { "1091",   "Hop 'n Pop" },
            { "1201",   "Alpha Eagle" },
            { "1472",   "The Cursed King" },
            { "1118",   "Joker Bombs" },
            { "1271",   "Fear The Dark" },
            { "1290",   "Commander of Tridents" },
            { "1135",   "The Bowery Boys" },
            { "1305",   "Mighty Masks" },
            { "1059",   "Chaos Crew" },
            { "1340",   "Vending Machine" },
            { "1372",   "Feel the Beat" },
            { "1474",   "Orb of Destiny" },
            { "1221",   "Gronk's Gems" },
            { "1414",   "Merlin's Alchemy" },
            { "1189",   "Born WILD" },
            { "1069",   "Cubes2" },
            { "1205",   "BreakBones" },
            { "1093",   "Xpander" },
            { "1498",   "Piggy Cluster Hunt" },
            { "1255",   "Lord Venom" },
            { "1197",   "Fruit Duel" },
            { "1176",   "Buffalo Stack 'n' Sync" },
            { "1127",   "King Carrot" },
            { "1140",   "Harvest Wilds" },
            { "1376",   "Mafia Clash" },
            { "1301",   "Sleepy Grandpa" },
            { "1412",   "Blademaster" },
            { "1150",   "Coins" },
            { "1131",   "Warrior Ways" },
            { "1055",   "Cash Compass" },
            { "1102",   "Rocket Reels" },
            { "1096",   "Tasty Treats" },
            { "1185",   "Forest Fortune" },
            { "1071",   "Mystery Motel" },
            { "1099",   "Cash Quest" },
            { "1058",   "The Respinners" },
            { "1139",   "Stack'em Scratch" },
            { "1259",   "Keep'em Cool" },
            { "1081",   "Frutz" },
            { "1070",   "Let It Snow" },
            { "1048",   "Cubes" },
            { "1092",   "Chaos Crew Scratch" },
            { "1014",   "Happy Scratch" },
            { "1027",   "Lucky Numbers x8" },
            { "1043",   "OmNom" },
            { "1156",   "Boxes" },
            { "1066",   "Aztec Twist" },
            { "1080",   "The Perfect Scratch" },
            { "1049",   "MiamiMultiplier" },
            { "1016",   "Lucky Scratch" },
            { "1042",   "Stickem" },
            { "1023",   "Lucky Shot" },
            { "1418",   "TWENTY-ONE" },
            { "1382",   "Blocks" },
            { "1110",   "Tiger Scratch" },
            { "1028",   "Lucky Numbers x12" },
            { "1022",   "Diamond Rush" },
            { "1008",   "Scratchy" },
            { "1063",   "Rat Riches" },
            { "1051",   "Frogs Scratch" },
            { "1011",   "Queen Treasure" },
            { "1024",   "Cash Vault I" },
            { "1009",   "Scratchy Big" },
            { "1029",   "Lucky Numbers x16" },
            { "1082",   "Eggstra Cash" },
            { "1109",   "Snow Scratcher" },
            { "1001",   "Platinum Scratch" },
            { "1020",   "Gold Rush" },
            { "1180",   "Summer Scratch" },
            { "1021",   "Ruby Rush" },
            { "1046",   "Cut the GRASS" },
            { "1025",   "Cash Vault II" },
            { "1004",   "Bronze scratch" },
            { "1007",   "Scratchy Mini" },
            { "1017",   "Dream Car Urban" },
            { "1050",   "Break the ICE" },
            { "1053",   "Koi Cash" },
            { "1060",   "Shave the Sheep" },
            { "1057",   "Cash Scratch" },
            { "1062",   "Crazy Donuts" },
            { "1003",   "Silver Scratch" },
            { "1030",   "Lucky Numbers x20" },
            { "1064",   "Go Panda!" },
            { "1388",   "COLORS" },
            { "1108",   "Scary Spooky Scratchy" },
            { "1031",   "It's Bananas" },
            { "1045",   "Shave the BEARD" },
            { "1010",   "King Treasure" },
            { "1002",   "Gold Scratch" },
            { "1052",   "Gold Coins" },
            { "1061",   "Balloons" },
            { "1047",   "Scratch'em" },
            { "1034",   "Double Salary 1 Year" },
            { "1079",   "Football Scratch" },
            { "1019",   "Dream Car Speed" },
            { "1065",   "Cash Pool" },
            { "1006",   "Express 200" },
            { "1072",   "Love is all you need" },
            { "1013",   "Prince Treasure" },
            { "1018",   "Dream Car SUV" }
        };

        public MainForm()
        {
            InitializeComponent();
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Multiselect = true,
                Filter = "HAR files (*.har)|*.har|All files (*.*)|*.*"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                selectedFiles = openFileDialog.FileNames.ToList();
                fileListView.Items.Clear();
                foreach (var file in selectedFiles)
                {
                    fileListView.Items.Add(new ListViewItem(file));
                }
            }
        }

        private async void startButton_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in fileListView.Items)
            {
                var filePath = item.Text;
                await ParseAndSaveFile(filePath);
                item.SubItems.Add("Done");
            }

            MessageBox.Show("Parsing completed.");
        }

        private async Task ParseAndSaveFile(string filePath)
        {
            try
            {
                var jsonData = await File.ReadAllTextAsync(filePath);
                var harData = JsonConvert.DeserializeObject<JObject>(jsonData);
                var entries = harData["log"]["entries"];
                var gameId = GetGameIdFromJson(jsonData);

                if (entries == null) return;

                var collectedData = new List<object>();

                foreach (var entry in entries)
                {
                    var request = entry["request"];
                    var response = entry["response"];

                    if (request != null && response != null &&
                        request["url"]?.ToString().Contains("com/api/play/bet") == true &&
                        request["postData"] != null)
                    {
                        var requestBody = request["postData"]["text"]?.ToString();
                        var responseBody = response["content"]["text"]?.ToString();

                        if (!string.IsNullOrEmpty(gameId) && gameCodeDic.TryGetValue(gameId, out var gameName))
                        {
                            var data = new
                            {
                                Request = requestBody,
                                Response = responseBody
                            };

                            collectedData.Add(data);
                        }
                    }
                }

                if (collectedData.Count > 0)
                {
                    var timestamp = DateTime.Now.ToString("yyyyMMddHHmmssfff");
                    var hashcode = GetMd5Hash(timestamp);
                    var fileName = Path.Combine(@"D:\Devel\slot\HAR-DATA Convertor\Result", $"{gameId}.{gameCodeDic[gameId].Replace(" ", "_")}.{hashcode}.data");

                    using (var writer = new StreamWriter(fileName))
                    {
                        foreach (var data in collectedData)
                        {
                            var dataJson = JsonConvert.SerializeObject(data);
                            await writer.WriteLineAsync(dataJson);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error parsing file {filePath}: {ex.Message}");
            }
        }

        public static string GetGameIdFromJson(string jsonData)
        {
            try
            {
                JObject parsedData = JObject.Parse(jsonData);
                string title = (string)parsedData["log"]["pages"][0]["title"];
                string gameId = ExtractGameIdFromTitle(title);
                return gameId;
            }
            catch
            {
                return null;
            }
        }

        private static string ExtractGameIdFromTitle(string title)
        {
            try
            {
                var uri = new Uri(title);
                var query = uri.Query;
                var queryDictionary = System.Web.HttpUtility.ParseQueryString(query);
                return queryDictionary["gameid"];
            }
            catch
            {
                return null;
            }
        }

        private string GetMd5Hash(string input)
        {
            using (var md5 = MD5.Create())
            {
                var inputBytes = Encoding.UTF8.GetBytes(input);
                var hashBytes = md5.ComputeHash(inputBytes);
                return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
            }
        }
    }
}
