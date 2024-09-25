using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Catalog.Api.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedData1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "Created", "IsDeleted", "LastModified", "Name", "Slug" },
                values: new object[,]
                {
                    { 17825, 1727259004.0623684, false, 0.0, "HP", "hp" },
                    { 17827, 1727259004.0609548, false, 0.0, "Apple", "apple" },
                    { 17839, 1727259004.0810621, false, 0.0, "UNO", "uno" },
                    { 18604, 1727259004.0633717, false, 0.0, "Lenovo", "lenovo" },
                    { 18634, 1727259004.0628402, false, 0.0, "Toshiba", "toshiba" },
                    { 18802, 1727259004.0609705, false, 0.0, "Samsung", "samsung" },
                    { 18804, 1727259004.0611005, false, 0.0, "Panasonic", "panasonic" },
                    { 18977, 1727259004.0745127, false, 0.0, "Bluestone", "bluestone" },
                    { 19018, 1727259004.0616596, false, 0.0, "Philips", "philips" },
                    { 19050, 1727259004.0823812, false, 0.0, "Electrolux", "electrolux" },
                    { 19588, 1727259004.0778489, false, 0.0, "Comet", "comet" },
                    { 19589, 1727259004.0678239, false, 0.0, "Kangaroo", "kangaroo" },
                    { 19673, 1727259004.0609641, false, 0.0, "Nokia", "nokia" },
                    { 19813, 1727259004.064008, false, 0.0, "Tefal", "tefal" },
                    { 19912, 1727259004.0721753, false, 0.0, "Sharp", "sharp" },
                    { 20056, 1727259004.0697284, false, 0.0, "Daewoo", "daewoo" },
                    { 20306, 1727259004.0848556, false, 0.0, "Rainy", "rainy" },
                    { 20439, 1727259004.0836072, false, 0.0, "Cuckoo", "cuckoo" },
                    { 20987, 1727259004.0656276, false, 0.0, "Novelty", "novelty" },
                    { 21104, 1727259004.069612, false, 0.0, "Gatsby", "gatsby" },
                    { 21253, 1727259004.0841279, false, 0.0, "Dabo", "dabo" },
                    { 21260, 1727259004.0751524, false, 0.0, "Mira", "mira" },
                    { 21261, 1727259004.0615151, false, 0.0, "Durex", "durex" },
                    { 21265, 1727259004.0651958, false, 0.0, "Dove", "dove" },
                    { 21266, 1727259004.0638647, false, 0.0, "Lifebuoy", "lifebuoy" },
                    { 21268, 1727259004.0752001, false, 0.0, "Sunsilk", "sunsilk" },
                    { 21269, 1727259004.0695961, false, 0.0, "Clear", "clear" },
                    { 21271, 1727259004.062803, false, 0.0, "P/S", "p-s" },
                    { 21273, 1727259004.0743444, false, 0.0, "Pond's", "pond-s" },
                    { 21274, 1727259004.0676661, false, 0.0, "Vaseline", "vaseline" },
                    { 21276, 1727259004.0639083, false, 0.0, "Pantene", "pantene" },
                    { 21278, 1727259004.0639017, false, 0.0, "Head & Shoulders", "head-&-shoulders" },
                    { 21279, 1727259004.0765767, false, 0.0, "Olay", "olay" },
                    { 21280, 1727259004.0771492, false, 0.0, "Camay", "camay" },
                    { 21282, 1727259004.0736473, false, 0.0, "Oral-B", "oral-b" },
                    { 21285, 1727259004.0651991, false, 0.0, "Axe", "axe" },
                    { 21407, 1727259004.0834544, false, 0.0, "Aroma", "aroma" },
                    { 21408, 1727259004.0743568, false, 0.0, "Mira Aroma", "mira-aroma" },
                    { 21584, 1727259004.0853024, false, 0.0, "BAMBO", "bambo" },
                    { 21651, 1727259004.0660338, false, 0.0, "Baseus", "baseus" },
                    { 21692, 1727259004.0728359, false, 0.0, "its well plus", "its-well-plus" },
                    { 21867, 1727259004.0651228, false, 0.0, "Kotex", "kotex" },
                    { 22013, 1727259004.0615184, false, 0.0, "Hada Labo", "hada-labo" },
                    { 22017, 1727259004.061065, false, 0.0, "Mobell", "mobell" },
                    { 22095, 1727259004.0616229, false, 0.0, "Sagami", "sa-ga-mi" },
                    { 22393, 1727259004.0627854, false, 0.0, "Rohto", "rohto" },
                    { 22653, 1727259004.0615416, false, 0.0, "Nivea", "nivea" },
                    { 24843, 1727259004.0633025, false, 0.0, "LEGO", "lego" },
                    { 24909, 1727259004.0665336, false, 0.0, "Calvin Klein", "calvin-klein" },
                    { 25009, 1727259004.0672903, false, 0.0, "Siku", "siku" },
                    { 25048, 1727259004.0664408, false, 0.0, "Maybelline", "maybelline" },
                    { 25159, 1727259004.0659876, false, 0.0, "Smart Fetus", "smart-fetus" },
                    { 25229, 1727259004.0817406, false, 0.0, "Bosch", "bosch" },
                    { 25401, 1727259004.0783072, false, 0.0, "Eveline", "eveline" },
                    { 25403, 1727259004.0639117, false, 0.0, "L'ORÉAL", "l-oreal" },
                    { 25422, 1727259004.0610058, false, 0.0, "Xiaomi", "xiaomi" },
                    { 25533, 1727259004.0803475, false, 0.0, "Maxcare", "marcare" },
                    { 25643, 1727259004.0609484, false, 0.0, "OPPO", "oppo" },
                    { 25706, 1727259004.0697217, false, 0.0, "Tiross", "tiross" },
                    { 26124, 1727259004.0659575, false, 0.0, "Arau Baby", "arau-baby" },
                    { 26225, 1727259004.0721092, false, 0.0, "Costar", "costar" },
                    { 26233, 1727259004.0735176, false, 0.0, "Tia Sáng", "tia-sang" },
                    { 26283, 1727259004.0608673, false, 0.0, "Pigeon", "pigeon" },
                    { 26689, 1727259004.0665135, false, 0.0, "VICHY", "vichy" },
                    { 26692, 1727259004.0787663, false, 0.0, "GOO.N", "goo-n" },
                    { 26702, 1727259004.0607586, false, 0.0, "Huggies", "huggies" },
                    { 26718, 1727259004.0811546, false, 0.0, "Stanley", "stanley" },
                    { 26779, 1727259004.0632491, false, 0.0, "HiPP", "hipp" },
                    { 26782, 1727259004.0644472, false, 0.0, "Philips Avent", "philip-avent" },
                    { 26793, 1727259004.080152, false, 0.0, "Nano", "nano" },
                    { 26809, 1727259004.0620904, false, 0.0, "Moony", "moony" },
                    { 26848, 1727259004.0632336, false, 0.0, "Morinaga", "morinaga" },
                    { 26855, 1727259004.0692821, false, 0.0, "Richell", "richell" },
                    { 26863, 1727259004.0607848, false, 0.0, "Bobby", "bobby" },
                    { 26878, 1727259004.0735078, false, 0.0, "Dr.Brown's", "dr-browns" },
                    { 27314, 1727259004.0733848, false, 0.0, "Bubchen", "bubchen" },
                    { 27378, 1727259004.0832813, false, 0.0, "Comotomo", "comotomo" },
                    { 27396, 1727259004.0777946, false, 0.0, "Puritan's Pride", "puritan-pride" },
                    { 27449, 1727259004.0664372, false, 0.0, "Beurer", "beurer" },
                    { 27658, 1727259004.0801208, false, 0.0, "Bino", "bino" },
                    { 27668, 1727259004.0658326, false, 0.0, "Merries", "merries" },
                    { 27918, 1727259004.0664999, false, 0.0, "TRESemmé", "tresemme" },
                    { 27932, 1727259004.0646009, false, 0.0, "TCL", "tcl" },
                    { 28005, 1727259004.0845549, false, 0.0, "Sport1", "sport1" },
                    { 31580, 1727259004.0789073, false, 0.0, "Mayan", "mayan" },
                    { 31627, 1727259004.0616467, false, 0.0, "Elmich", "elmich" },
                    { 31835, 1727259004.0750051, false, 0.0, "Lactacyd", "lactacyd" },
                    { 31933, 1727259004.0810363, false, 0.0, "Suri", "suri" },
                    { 31978, 1727259004.0609739, false, 0.0, "Alcatel", "alcatel" },
                    { 32539, 1727259004.060766, false, 0.0, "Friso", "friso" },
                    { 32865, 1727259004.0752904, false, 0.0, "Kimono", "kimono" },
                    { 33203, 1727259004.0616004, false, 0.0, "Omron", "omron" },
                    { 33255, 1727259004.0782149, false, 0.0, "Ku.Ku Duckbill", "ku.ku-duckbill" },
                    { 33283, 1727259004.0644217, false, 0.0, "Abbott", "abbott" },
                    { 33361, 1727259004.0624974, false, 0.0, "Glico", "glico" },
                    { 33558, 1727259004.0734353, false, 0.0, "Nestlé", "nestle" },
                    { 33562, 1727259004.0607345, false, 0.0, "NAN", "nan" },
                    { 34398, 1727259004.0652721, false, 0.0, "Microlife", "microlife" },
                    { 40383, 1727259004.0769117, false, 0.0, "Rock", "rock" },
                    { 40699, 1727259004.0735269, false, 0.0, "Prota", "prota" },
                    { 40810, 1727259004.074456, false, 0.0, "Phú Quý", "phu-quy" },
                    { 41048, 1727259004.0616336, false, 0.0, "Sunhouse", "sunhouse" },
                    { 41408, 1727259004.0780349, false, 0.0, "Makita", "makita" },
                    { 41660, 1727259004.0676591, false, 0.0, "Johnson's Baby", "johnson-s-baby" },
                    { 41661, 1727259004.0795548, false, 0.0, "LISTERINE", "listerine" },
                    { 45784, 1727259004.0657227, false, 0.0, "Relax", "relax" },
                    { 45868, 1727259004.0727596, false, 0.0, "FUJIYA", "fujiya" },
                    { 45884, 1727259004.0817206, false, 0.0, "Titan", "titan" },
                    { 46007, 1727259004.0695565, false, 0.0, "OHUI", "ohui" },
                    { 46047, 1727259004.0750401, false, 0.0, "Hoa Lúa", "hoa-lua" },
                    { 46295, 1727259004.0822625, false, 0.0, "LIGO", "ligo" },
                    { 46298, 1727259004.0750945, false, 0.0, "DEL MONTE", "del-monte" },
                    { 46335, 1727259004.0614488, false, 0.0, "Gillette", "gillette" },
                    { 46679, 1727259004.0756404, false, 0.0, "Huy Hoàng", "huy-hoang" },
                    { 46703, 1727259004.0622044, false, 0.0, "Deli", "deli" },
                    { 46764, 1727259004.0626156, false, 0.0, "ZARA BEAN COFFEE", "zara-bean-coffee" },
                    { 47422, 1727259004.0760157, false, 0.0, "Nhơn Hòa", "nhon-hoa" },
                    { 47427, 1727259004.075238, false, 0.0, "Accu-Chek", "accu-chek" },
                    { 47433, 1727259004.0766091, false, 0.0, "Chong Kun Dang", "chong-kun-dang" },
                    { 47445, 1727259004.0708404, false, 0.0, "Puma", "puma" },
                    { 47448, 1727259004.085428, false, 0.0, "Gucci", "gucci" },
                    { 47489, 1727259004.0705006, false, 0.0, "La Roche-Posay", "la-roche-posay" },
                    { 47553, 1727259004.0709252, false, 0.0, "Juno", "juno" },
                    { 47663, 1727259004.0771365, false, 0.0, "Romano", "romano" },
                    { 47664, 1727259004.0651133, false, 0.0, "Enchanteur ", "enchanteur" },
                    { 47776, 1727259004.0620704, false, 0.0, "Caryn", "caryn" },
                    { 47780, 1727259004.0612977, false, 0.0, "Sapporo", "sapporo" },
                    { 47791, 1727259004.0760777, false, 0.0, "Fujie", "fujie" },
                    { 47794, 1727259004.0744135, false, 0.0, "Double Rich", "double-rich" },
                    { 47803, 1727259004.0696747, false, 0.0, "Orihiro", "orihiro" },
                    { 47970, 1727259004.0792162, false, 0.0, "F2 Fashion", "f2-fashion" },
                    { 48014, 1727259004.0828092, false, 0.0, "Winwintoys", "winwintoys" },
                    { 48018, 1727259004.0653677, false, 0.0, "Miley Lingerie", "miley-lingerie" },
                    { 48077, 1727259004.06163, false, 0.0, "LocknLock", "locknlock" },
                    { 48249, 1727259004.0650496, false, 0.0, "Silcot", "silcot" },
                    { 48257, 1727259004.075037, false, 0.0, "Simply", "simply" },
                    { 48258, 1727259004.0649021, false, 0.0, "Neptune", "neptune" },
                    { 48390, 1727259004.0676825, false, 0.0, "Dyeing Pyeonan", "dyeing-pyeonan" },
                    { 48399, 1727259004.0651925, false, 0.0, "Schwarzkopf", "schwarzkopf" },
                    { 48462, 1727259004.068141, false, 0.0, "Nike", "nike" },
                    { 48490, 1727259004.0750115, false, 0.0, "BoardgameVN", "boardgamevn" },
                    { 48645, 1727259004.0692015, false, 0.0, "UniDry", "unidry" },
                    { 48647, 1727259004.0621197, false, 0.0, "SunMate", "sunmate" },
                    { 48649, 1727259004.0784612, false, 0.0, "Braun", "braun" },
                    { 48664, 1727259004.0682151, false, 0.0, "UniFresh", "unifresh" },
                    { 48668, 1727259004.0645647, false, 0.0, "Unimom", "unimom" },
                    { 48727, 1727259004.0651195, false, 0.0, "Jomi", "jomi" },
                    { 48731, 1727259004.0833709, false, 0.0, "Mother-K", "mother-k" },
                    { 48868, 1727259004.0681376, false, 0.0, "Phúc An", "phuc-an" },
                    { 48958, 1727259004.0692551, false, 0.0, "Tanamera", "tanamera" },
                    { 49204, 1727259004.0614293, false, 0.0, "SCENTIO", "scentio" },
                    { 49242, 1727259004.0664704, false, 0.0, "Diana", "diana" },
                    { 49331, 1727259004.0841997, false, 0.0, "Kachi", "kachi" },
                    { 49369, 1727259004.0620539, false, 0.0, "Pierre Cardin", "pierre-cardin" },
                    { 49994, 1727259004.0633223, false, 0.0, "ZTE", "zte" },
                    { 50072, 1727259004.081656, false, 0.0, "GREEN CROSS", "green-cross" },
                    { 50432, 1727259004.0677056, false, 0.0, "Kerasys", "kerasys" },
                    { 50653, 1727259004.0751331, false, 0.0, "Mentholatum", "mentholatum" },
                    { 50662, 1727259004.0638812, false, 0.0, "BIODERMA", "bioderma" },
                    { 50693, 1727259004.0728457, false, 0.0, "VEET", "veet" },
                    { 50699, 1727259004.0769427, false, 0.0, "Hando", "hando" },
                    { 50800, 1727259004.0744936, false, 0.0, "Aquafresh", "aquafresh" },
                    { 50807, 1727259004.0784421, false, 0.0, "Sensodyne", "sensodyne" },
                    { 51196, 1727259004.0846779, false, 0.0, "Cross", "cross" },
                    { 51264, 1727259004.0653288, false, 0.0, "Perfect", "perfect" },
                    { 51319, 1727259004.064306, false, 0.0, "Phúc An Fashion", "phuc-an-fashion" },
                    { 51325, 1727259004.070616, false, 0.0, "Mishio", "mishio" },
                    { 51646, 1727259004.0673761, false, 0.0, "Bamboo", "bamboo" },
                    { 51660, 1727259004.0651495, false, 0.0, "EAGLE BRAND", "dau-xanh-con-o" },
                    { 52232, 1727259004.0770445, false, 0.0, "Vivo", "vivo" },
                    { 52304, 1727259004.0629332, false, 0.0, "iBasic", "ibasic" },
                    { 52347, 1727259004.0621779, false, 0.0, "Anlene", "anlene" },
                    { 52401, 1727259004.0678208, false, 0.0, "Karcher", "karcher" },
                    { 53040, 1727259004.0751648, false, 0.0, "Dettol", "dettol" },
                    { 53194, 1727259004.0834951, false, 0.0, "Ngọc Tuyết", "ngoc-tuyet" },
                    { 53557, 1727259004.0621977, false, 0.0, "VINANOI", "vinanoi" },
                    { 53755, 1727259004.0793986, false, 0.0, "Yuniku", "yuniku" },
                    { 53819, 1727259004.0653508, false, 0.0, "Karofi", "karofi" },
                    { 63747, 1727259004.0652552, false, 0.0, "3M", "3m" },
                    { 63894, 1727259004.0628469, false, 0.0, "Kemei", "kemei" },
                    { 64201, 1727259004.0608706, false, 0.0, "D-nee", "d-nee" },
                    { 64932, 1727259004.0638444, false, 0.0, "Laneige", "laneige" },
                    { 64943, 1727259004.0676792, false, 0.0, "MEGUMI", "megumi" },
                    { 65095, 1727259004.0623848, false, 0.0, "Cisco", "cisco" },
                    { 65122, 1727259004.0621388, false, 0.0, "Vinamilk", "vinamilk" },
                    { 74649, 1727259004.0709188, false, 0.0, "Bejo", "bejo" },
                    { 74674, 1727259004.0638914, false, 0.0, "Bigen", "bigen" },
                    { 74832, 1727259004.0628333, false, 0.0, "Pureit", "pureit" },
                    { 79528, 1727259004.0698566, false, 0.0, "Wannabe", "wannabe" },
                    { 79682, 1727259004.0615115, false, 0.0, "Colgate", "colgate" },
                    { 79688, 1727259004.0627508, false, 0.0, "Palmolive", "palmolive" },
                    { 79709, 1727259004.0734067, false, 0.0, "Mamamy", "mamamy" },
                    { 79991, 1727259004.0826797, false, 0.0, "Aristino", "aristino" },
                    { 80003, 1727259004.0720451, false, 0.0, "So Easy", "so-easy" },
                    { 84936, 1727259004.0612459, false, 0.0, "President", "president" },
                    { 85338, 1727259004.0783341, false, 0.0, "Carebeau", "carebeau" },
                    { 85867, 1727259004.0782945, false, 0.0, "Aquaselin", "aquaselin" },
                    { 86206, 1727259004.0751076, false, 0.0, "Senka", "senka" },
                    { 110481, 1727259004.0627718, false, 0.0, "Hapaku", "hapaku" },
                    { 110666, 1727259004.0835111, false, 0.0, "Immortel", "immortel" },
                    { 110806, 1727259004.0608804, false, 0.0, "Lucky", "lucky" },
                    { 110935, 1727259004.0790782, false, 0.0, "Nagakawa", "nagakawa" },
                    { 111422, 1727259004.0638583, false, 0.0, "Peppy", "peppy" },
                    { 111461, 1727259004.0612097, false, 0.0, "OEM", "oem" },
                    { 111545, 1727259004.0742276, false, 0.0, "Athena", "athena" },
                    { 111684, 1727259004.0610588, false, 0.0, "Itel", "itel" },
                    { 112081, 1727259004.0614846, false, 0.0, "COFFEE TREE", "coffee-tree" },
                    { 112338, 1727259004.0608025, false, 0.0, "Enfa", "enfa" },
                    { 112638, 1727259004.0610781, false, 0.0, "Masstel", "masstel" },
                    { 112654, 1727259004.0717726, false, 0.0, "Suave", "suave" },
                    { 112735, 1727259004.0622993, false, 0.0, "Oukitel", "oukitel" },
                    { 112815, 1727259004.0757017, false, 0.0, "Wesser", "wesser" },
                    { 112878, 1727259004.0716789, false, 0.0, "Agi", "agi" },
                    { 112882, 1727259004.063808, false, 0.0, "Sunplay", "sunplay" },
                    { 112883, 1727259004.0783172, false, 0.0, "LipIce", "lipice" },
                    { 112885, 1727259004.0615654, false, 0.0, "Selsun", "selsun" },
                    { 112886, 1727259004.0615084, false, 0.0, "OXY", "oxy" },
                    { 112887, 1727259004.0615051, false, 0.0, "Acnes", "acnes" },
                    { 112920, 1727259004.0720773, false, 0.0, "MARC JACOBS", "marc-jacobs" },
                    { 112923, 1727259004.0630047, false, 0.0, "GIORDANO", "giordano" },
                    { 112942, 1727259004.0810754, false, 0.0, "Valentino", "valentino" },
                    { 112961, 1727259004.0652056, false, 0.0, "GIORGIO ARMANI", "giorgio-armani" },
                    { 112979, 1727259004.072823, false, 0.0, "Rocket", "rocket" },
                    { 113125, 1727259004.0766156, false, 0.0, "AZODRA", "azodra" },
                    { 114060, 1727259004.0615752, false, 0.0, "Laurelle London", "laurelle-london" },
                    { 114113, 1727259004.0695331, false, 0.0, "Bio Apgold", "bio-apgold" },
                    { 114133, 1727259004.0811479, false, 0.0, "ASIA", "asia" },
                    { 114225, 1727259004.0853968, false, 0.0, "NEOP", "neop" },
                    { 114328, 1727259004.0651362, false, 0.0, "Eucerin", "eucerin" },
                    { 114329, 1727259004.0616167, false, 0.0, "AlcoFree", "alcofree" },
                    { 114333, 1727259004.0721123, false, 0.0, "Blossomy", "blossomy" },
                    { 114568, 1727259004.0666726, false, 0.0, "SENKO", "senko" },
                    { 114578, 1727259004.0692279, false, 0.0, "Gold", "gold" },
                    { 142542, 1727259004.073667, false, 0.0, "Benew", "benew" },
                    { 142547, 1727259004.0717156, false, 0.0, "Zera", "zera" },
                    { 142558, 1727259004.0804055, false, 0.0, "ROSABELA", "rosabela" },
                    { 142850, 1727259004.0756683, false, 0.0, "GB Shop", "gb-shop" },
                    { 142871, 1727259004.0655541, false, 0.0, "Hity", "hity" },
                    { 143006, 1727259004.0638378, false, 0.0, "Dorco", "dorco" },
                    { 143017, 1727259004.0664439, false, 0.0, "Dior", "dior" },
                    { 143130, 1727259004.0651565, false, 0.0, "Lorganic", "lorganic" },
                    { 143210, 1727259004.0744264, false, 0.0, "Prada", "prada" },
                    { 143278, 1727259004.0766349, false, 0.0, "OSAKA", "osaka" },
                    { 143393, 1727259004.0729461, false, 0.0, "Homepro", "homepro" },
                    { 143405, 1727259004.0676692, false, 0.0, "Slimming Care Vietnam", "slimming-care-vietnam" },
                    { 143476, 1727259004.0652356, false, 0.0, "Vacosi", "vacosi" },
                    { 143607, 1727259004.0639405, false, 0.0, "Kai", "kai" },
                    { 143682, 1727259004.0702925, false, 0.0, "Senta", "senta" },
                    { 143721, 1727259004.0682611, false, 0.0, "Bảo Nhiên", "bao-nhien" },
                    { 143817, 1727259004.084729, false, 0.0, "Beauskin", "beauskin" },
                    { 144467, 1727259004.0669887, false, 0.0, "Titishop", "titishop" },
                    { 144852, 1727259004.0841479, false, 0.0, "Uriage", "uriage" },
                    { 144900, 1727259004.0795484, false, 0.0, "St Michel", "st-michel" },
                    { 144902, 1727259004.0613472, false, 0.0, "Loacker", "loacker" },
                    { 144936, 1727259004.0608304, false, 0.0, "Meiji", "meiji" },
                    { 144937, 1727259004.0743299, false, 0.0, "Languly", "languly" },
                    { 145037, 1727259004.0627925, false, 0.0, "Tâm Thiện Chí", "tam-thien-chi" },
                    { 145040, 1727259004.0696912, false, 0.0, "Powermen", "powermen" },
                    { 145041, 1727259004.0609081, false, 0.0, "Powertest", "powertest" },
                    { 145125, 1727259004.0650232, false, 0.0, "Itoen", "itoen" },
                    { 145192, 1727259004.0682676, false, 0.0, "Wonmom", "wonmom" },
                    { 145335, 1727259004.0677485, false, 0.0, "Kirkland", "kirkland" },
                    { 145337, 1727259004.0829184, false, 0.0, "NeoCell", "neocell" },
                    { 145339, 1727259004.0621617, false, 0.0, "Vitabiotics", "vitabiotics" },
                    { 145615, 1727259004.0730135, false, 0.0, "AAA JEANS", "aaa-jeans" },
                    { 145656, 1727259004.0652816, false, 0.0, "Bayer", "bayer" },
                    { 145874, 1727259004.0743735, false, 0.0, "The Rucy", "the-rucy" },
                    { 145914, 1727259004.0766587, false, 0.0, "Honjianda", "honjianda" },
                    { 145924, 1727259004.0608439, false, 0.0, "Ensure", "ensure" },
                    { 146067, 1727259004.0700045, false, 0.0, "Vĩnh Tiến", "vinh-tien" },
                    { 146099, 1727259004.0717793, false, 0.0, "Pipovietnam", "pipovietnam" },
                    { 146403, 1727259004.0679977, false, 0.0, "Gold Rhino", "gold-rhino" },
                    { 146509, 1727259004.0817502, false, 0.0, "Hatari", "hatari" },
                    { 147729, 1727259004.0608835, false, 0.0, "Antona", "antona" },
                    { 147856, 1727259004.0610192, false, 0.0, "Kindle", "kindle" },
                    { 148049, 1727259004.0730734, false, 0.0, "No", "no" },
                    { 148377, 1727259004.0659106, false, 0.0, "Real Food Store", "real-food-store" },
                    { 148534, 1727259004.0627232, false, 0.0, "BBIA", "bbia" },
                    { 148535, 1727259004.0796704, false, 0.0, "Kim Cương", "kim-cuong" },
                    { 148685, 1727259004.0632241, false, 0.0, "Nutren", "nutren" },
                    { 148775, 1727259004.0686333, false, 0.0, "DIANA", "diana" },
                    { 148844, 1727259004.0854001, false, 0.0, "OGATIC", "ogatic" },
                    { 149148, 1727259004.0759435, false, 0.0, "Lover's Care", "lovers-care" },
                    { 149699, 1727259004.0659509, false, 0.0, "Cetaphil", "cetaphil" },
                    { 149735, 1727259004.0658691, false, 0.0, "Similac", "similac" },
                    { 149737, 1727259004.0607882, false, 0.0, "Pediasure", "pediasure" },
                    { 149739, 1727259004.0632138, false, 0.0, "Grow", "grow" },
                    { 149741, 1727259004.0631597, false, 0.0, "Glucerna", "glucerna" },
                    { 150201, 1727259004.0619521, false, 0.0, "Việt Tiến", "viet-tien" },
                    { 150343, 1727259004.0840836, false, 0.0, "Galaxy Store", "galaxy-store" },
                    { 150426, 1727259004.0841024, false, 0.0, "Mattel Games", "mattel-games" },
                    { 150700, 1727259004.0728748, false, 0.0, "Montblanc", "montblanc" },
                    { 150769, 1727259004.0811448, false, 0.0, "Hans", "hans" },
                    { 151061, 1727259004.0744655, false, 0.0, "Tỏi Kim Cương Đông Á", "toi-kim-cuong-dong-a" },
                    { 151473, 1727259004.0745029, false, 0.0, "Midimori", "midimori" },
                    { 151853, 1727259004.0776274, false, 0.0, "Nuby", "nuby" },
                    { 151948, 1727259004.0615718, false, 0.0, "Charme", "charme" },
                    { 152021, 1727259004.073813, false, 0.0, "GIGI", "gigi" },
                    { 152240, 1727259004.0790265, false, 0.0, "Dudaco", "dudaco" },
                    { 152355, 1727259004.0808809, false, 0.0, "Nuna", "nuna" },
                    { 152359, 1727259004.0725088, false, 0.0, "BabyHood", "babyhood" },
                    { 152363, 1727259004.0658555, false, 0.0, "Let-green", "let-green" },
                    { 152386, 1727259004.0854564, false, 0.0, "SANITY", "sanity" },
                    { 152440, 1727259004.0841377, false, 0.0, "ISIS Pharma", "isis-pharma" },
                    { 152628, 1727259004.0659075, false, 0.0, "XO", "xo" },
                    { 152786, 1727259004.0705996, false, 0.0, "Boss", "boss" },
                    { 153059, 1727259004.0609217, false, 0.0, "SafeFit", "safefit" },
                    { 153079, 1727259004.0741961, false, 0.0, "Absolute Organic", "absolute-organic" },
                    { 153135, 1727259004.0787599, false, 0.0, "Goodmama", "goodmama" },
                    { 153438, 1727259004.0612164, false, 0.0, "NutiFood", "nutifood" },
                    { 153444, 1727259004.0793049, false, 0.0, "Yamaha", "yamaha" },
                    { 153494, 1727259004.0700667, false, 0.0, "Bee Gee", "bee-gee" },
                    { 153609, 1727259004.0664339, false, 0.0, "VACCI", "vacci" },
                    { 153733, 1727259004.0752606, false, 0.0, "Shiseido", "shiseido" },
                    { 154005, 1727259004.0764656, false, 0.0, "Spectra", "spectra" },
                    { 154319, 1727259004.0791883, false, 0.0, "868", "868" },
                    { 154475, 1727259004.0631764, false, 0.0, "Bowa", "bowa" },
                    { 154733, 1727259004.0615251, false, 0.0, "Lip On Lip", "lip-on-lip" },
                    { 154777, 1727259004.0650463, false, 0.0, "OneLife", "onelife" },
                    { 154839, 1727259004.0638781, false, 0.0, "Organic Shop", "organic-shop" },
                    { 154941, 1727259004.0702319, false, 0.0, "Foxi", "foxi" },
                    { 155505, 1727259004.0664639, false, 0.0, "Fobelife", "fobelife" },
                    { 155516, 1727259004.0626717, false, 0.0, "Quảng Thanh", "quang-thanh" },
                    { 155524, 1727259004.0696485, false, 0.0, "Karibon", "karibon" },
                    { 155681, 1727259004.0635183, false, 0.0, "Maya", "maya" },
                    { 156043, 1727259004.0609283, false, 0.0, "Dân Khang", "dan-khang" },
                    { 156143, 1727259004.0676527, false, 0.0, "Refre", "refre" },
                    { 156145, 1727259004.0758841, false, 0.0, "Melano CC", "melano-cc" },
                    { 156167, 1727259004.0620575, false, 0.0, "Aptamil", "aptamil" },
                    { 156251, 1727259004.0811007, false, 0.0, "Care", "care" },
                    { 156365, 1727259004.0631564, false, 0.0, "Gerber", "gerber" },
                    { 157231, 1727259004.0616839, false, 0.0, "KHANH LINH STYLE", "khanh-linh-style" },
                    { 157347, 1727259004.0728779, false, 0.0, "Nikio", "nikio" },
                    { 159127, 1727259004.062418, false, 0.0, "Sài Gòn Food", "sai-gon-food" },
                    { 159219, 1727259004.0709617, false, 0.0, "Liên Hiệp Thành", "lien-hiep-thanh" },
                    { 159835, 1727259004.0631001, false, 0.0, "LADOS", "lados" },
                    { 160057, 1727259004.0769796, false, 0.0, "Asumiru", "asumiru" },
                    { 160209, 1727259004.0620475, false, 0.0, "Rosata", "rosata" },
                    { 160211, 1727259004.0627005, false, 0.0, "ANESSA", "anessa" },
                    { 161077, 1727259004.0652521, false, 0.0, "Duy Thành", "duy-thanh" },
                    { 161535, 1727259004.0660272, false, 0.0, "Honor", "honor" },
                    { 162007, 1727259004.0645847, false, 0.0, "Tecno", "tecno" },
                    { 162041, 1727259004.0750721, false, 0.0, "Đại Việt", "dai-viet" },
                    { 162177, 1727259004.0664539, false, 0.0, "Lipice Sheer Color", "lipice-sheer-color" },
                    { 162447, 1727259004.0750017, false, 0.0, "Muslin Tree", "muslin-tree" },
                    { 163271, 1727259004.0703835, false, 0.0, "LOTTE", "lotte" },
                    { 163297, 1727259004.0614457, false, 0.0, "Cocoxim", "cocoxim" },
                    { 164391, 1727259004.0651097, false, 0.0, "Remos", "remos" },
                    { 164393, 1727259004.0789626, false, 0.0, "Happy Event", "happy-event" },
                    { 164523, 1727259004.0608132, false, 0.0, "Anmum", "anmum" },
                    { 164597, 1727259004.0772352, false, 0.0, "Codos", "codos" },
                    { 165237, 1727259004.072952, false, 0.0, "Magic", "magic" },
                    { 166383, 1727259004.0704505, false, 0.0, "Serenys", "serenys" },
                    { 166941, 1727259004.0841444, false, 0.0, "Coboté", "cobote" },
                    { 167031, 1727259004.0609009, false, 0.0, "Triumph", "triumph" },
                    { 168053, 1727259004.067241, false, 0.0, "Franci", "franci" },
                    { 168433, 1727259004.0648608, false, 0.0, "Oldenburger", "oldenburger" },
                    { 168543, 1727259004.0619881, false, 0.0, "FWD", "fwd" },
                    { 168749, 1727259004.0645239, false, 0.0, "FatzBaby", "fatzbaby" },
                    { 169013, 1727259004.0646117, false, 0.0, "Ulefone", "ulefone" },
                    { 169845, 1727259004.0854917, false, 0.0, "Eurolife", "eurolife" },
                    { 169917, 1727259004.0853648, false, 0.0, "The Saem", "the-saem" },
                    { 171169, 1727259004.0633547, false, 0.0, "VNPT Technology", "vnpt-technology" },
                    { 174389, 1727259004.0686755, false, 0.0, "YAMADA", "yamada" },
                    { 174391, 1727259004.0829115, false, 0.0, "INOMATA", "inomata" },
                    { 174449, 1727259004.0682316, false, 0.0, "Hikid", "hikid" },
                    { 175545, 1727259004.0781603, false, 0.0, "Likado", "likado" },
                    { 177813, 1727259004.0789592, false, 0.0, "Byphasse", "byphasse" },
                    { 177833, 1727259004.0835433, false, 0.0, "OneX", "onex" },
                    { 177897, 1727259004.0669062, false, 0.0, "P2P Bikini", "p2p-bikini" },
                    { 177913, 1727259004.0808508, false, 0.0, "GEOX", "geox" },
                    { 178303, 1727259004.0616133, false, 0.0, "KGS", "kgs" },
                    { 178551, 1727259004.0687056, false, 0.0, "Vitis", "vitis" },
                    { 179051, 1727259004.0657525, false, 0.0, "Muidoi", "muidoi" },
                    { 179125, 1727259004.069705, false, 0.0, "Crest", "crest" },
                    { 179385, 1727259004.0781925, false, 0.0, "Yến Việt", "yen-viet" },
                    { 179693, 1727259004.0763786, false, 0.0, "Song Long", "song-long" },
                    { 181325, 1727259004.0802929, false, 0.0, "KOLAN", "kolan" },
                    { 182139, 1727259004.063895, false, 0.0, "Aurane", "aurane" },
                    { 182293, 1727259004.0751712, false, 0.0, "Paula's Choice", "paula-s-choice" },
                    { 182349, 1727259004.0744011, false, 0.0, "VIETCOCO", "vietcoco" },
                    { 182365, 1727259004.068274, false, 0.0, "A2", "a2" },
                    { 182863, 1727259004.0652919, false, 0.0, "LifeStyles", "lifestyles" },
                    { 182969, 1727259004.0823879, false, 0.0, "Unold", "unold" },
                    { 183013, 1727259004.0744691, false, 0.0, "Goodhealth", "goodhealth" },
                    { 183251, 1727259004.0676396, false, 0.0, "M.O.I", "m-o-i" },
                    { 183315, 1727259004.0608337, false, 0.0, "Bio Island", "bio-island" },
                    { 183321, 1727259004.0608273, false, 0.0, "Ostelin", "ostelin" },
                    { 183325, 1727259004.0608094, false, 0.0, "Blackmores", "blackmores" },
                    { 183621, 1727259004.0619352, false, 0.0, "VICCI", "vicci" },
                    { 183625, 1727259004.0610557, false, 0.0, "Kobo", "kobo" },
                    { 183637, 1727259004.0610158, false, 0.0, "Onyx Boox", "onyx-boox" },
                    { 183657, 1727259004.0842669, false, 0.0, "Others", "others" },
                    { 183795, 1727259004.0653253, false, 0.0, "OKAMURA", "okamura" },
                    { 184299, 1727259004.0803957, false, 0.0, "Shell", "shell" },
                    { 185013, 1727259004.0840173, false, 0.0, "Teramo", "teramo" },
                    { 185075, 1727259004.0638247, false, 0.0, "SIMPLE", "simple" },
                    { 185235, 1727259004.0743828, false, 0.0, "Crevil", "crevil" },
                    { 185677, 1727259004.0664506, false, 0.0, "Legaxi", "legaxi" },
                    { 185875, 1727259004.0627434, false, 0.0, "Sao Thái Dương", "sao-thai-duong" },
                    { 186089, 1727259004.0794115, false, 0.0, "MAMA", "mama" },
                    { 186153, 1727259004.0683453, false, 0.0, "New4all", "new4all" },
                    { 186553, 1727259004.0827601, false, 0.0, "Fitobimbi", "fitobimbi" },
                    { 186751, 1727259004.0759499, false, 0.0, "Viet Healthy", "viet-healthy" },
                    { 189471, 1727259004.0638716, false, 0.0, "KOBI", "kobi" },
                    { 189509, 1727259004.0777917, false, 0.0, "AOLIKES", "aolikes" },
                    { 189593, 1727259004.0652883, false, 0.0, "G'EXlife ", "g-exlife" },
                    { 189947, 1727259004.0616436, false, 0.0, "Deerma", "deerma" },
                    { 190889, 1727259004.0644324, false, 0.0, "TH True Milk", "th-true-milk" },
                    { 192947, 1727259004.0686364, false, 0.0, "Doctor care", "doctor-care" },
                    { 193755, 1727259004.0831137, false, 0.0, "Luna Llena", "luna-llena" },
                    { 193967, 1727259004.0817535, false, 0.0, "ASIAvina", "asiavina" },
                    { 194025, 1727259004.0676627, false, 0.0, "JYSK", "jysk" },
                    { 194399, 1727259004.0644996, false, 0.0, "VitaDairy", "vitadairy" },
                    { 194403, 1727259004.063961, false, 0.0, "Doppel Herz", "doppel-herz" },
                    { 194565, 1727259004.0681658, false, 0.0, "Sifa", "sifa" },
                    { 195725, 1727259004.0827923, false, 0.0, "Kazi", "kazi" },
                    { 196171, 1727259004.0614951, false, 0.0, "BAKALLAND", "bakalland" },
                    { 196189, 1727259004.0752542, false, 0.0, "Quê Việt", "que-viet" },
                    { 196829, 1727259004.0841608, false, 0.0, "Yanhee", "yanhee" },
                    { 197443, 1727259004.0614223, false, 0.0, "Coast", "coast" },
                    { 197731, 1727259004.0828762, false, 0.0, "A-Derma", "a-derma" },
                    { 197767, 1727259004.0701025, false, 0.0, "Inochi", "inochi" },
                    { 198129, 1727259004.0809381, false, 0.0, "Boom Potty", "boom-potty" },
                    { 198523, 1727259004.0628166, false, 0.0, "Bear", "bear" },
                    { 198687, 1727259004.0800383, false, 0.0, "Malefix", "malefix" },
                    { 198777, 1727259004.0771697, false, 0.0, "lancome", "lancome" },
                    { 199431, 1727259004.0718856, false, 0.0, "Ecoba", "ecoba" },
                    { 199769, 1727259004.0743766, false, 0.0, "Eyemiru", "eyemiru" },
                    { 199801, 1727259004.0854628, false, 0.0, "KGC Cheong Kwan Jang", "kgc-cheong-kwan-jang" },
                    { 199919, 1727259004.070471, false, 0.0, "Clio", "clio" },
                    { 199927, 1727259004.0651891, false, 0.0, "M-pros", "m-pros" },
                    { 199937, 1727259004.072057, false, 0.0, "Thorakao", "thorakao" },
                    { 199975, 1727259004.0834639, false, 0.0, "Linh Hương", "linh-huong" },
                    { 200189, 1727259004.06161, false, 0.0, "DHC", "dhc" },
                    { 200819, 1727259004.0772784, false, 0.0, "Lamer", "lamer" },
                    { 201253, 1727259004.0764942, false, 0.0, "No Brand", "no-brand" },
                    { 202043, 1727259004.0817106, false, 0.0, "GO Healthy", "go-healthy" },
                    { 202071, 1727259004.0616198, false, 0.0, "Innova", "innova" },
                    { 202333, 1727259004.0645108, false, 0.0, "Nutricare", "nutricare" },
                    { 202395, 1727259004.0676224, false, 0.0, "LOREAL PARIS", "loreal-paris" },
                    { 202429, 1727259004.0795231, false, 0.0, "S&B", "s-b" },
                    { 202607, 1727259004.0615284, false, 0.0, "Innisfree", "innisfree" },
                    { 203101, 1727259004.0789361, false, 0.0, "Hanayuki", "hanayuki" },
                    { 203917, 1727259004.0705175, false, 0.0, "Welcos", "welcos" },
                    { 204023, 1727259004.068284, false, 0.0, "PQA", "pqa" },
                    { 204025, 1727259004.0692112, false, 0.0, "Pharmalife", "pharmalife" },
                    { 204141, 1727259004.0701923, false, 0.0, "Dr Papie", "dr-papie" },
                    { 204609, 1727259004.0659175, false, 0.0, "Namyang", "namyang" },
                    { 204611, 1727259004.0614779, false, 0.0, "Highlands Coffee", "highlands-coffee" },
                    { 204787, 1727259004.0833488, false, 0.0, "Etomil", "etomil" },
                    { 205197, 1727259004.0855012, false, 0.0, "HAFELE", "hafele" },
                    { 205395, 1727259004.0642734, false, 0.0, "Freeman", "freeman" },
                    { 205903, 1727259004.0828731, false, 0.0, "VITARA", "vitara" },
                    { 206523, 1727259004.0834353, false, 0.0, "Hoài Thương Organic", "hoai-thuong-organic" },
                    { 206727, 1727259004.0664008, false, 0.0, "Bibigo", "bibigo" },
                    { 206801, 1727259004.0662718, false, 0.0, "Nước Mắm Tĩn", "nuoc-mam-tin" },
                    { 207205, 1727259004.0802903, false, 0.0, "LUX", "lux" },
                    { 207249, 1727259004.0810552, false, 0.0, "White Conc", "white-conc" },
                    { 208677, 1727259004.0671611, false, 0.0, "Mr. Fresh", "mr-fresh" },
                    { 208741, 1727259004.0779436, false, 0.0, "Jobelli", "jobelli" },
                    { 210631, 1727259004.0828283, false, 0.0, "Cầu Tre", "cau-tre" },
                    { 210769, 1727259004.0693476, false, 0.0, "Hải Nam", "hai-nam" },
                    { 211343, 1727259004.0847576, false, 0.0, "STARBALM", "starbalm" },
                    { 211415, 1727259004.0627165, false, 0.0, "Kềm Nghĩa", "kem-nghia" },
                    { 211481, 1727259004.0793169, false, 0.0, "Aligo", "aligo" },
                    { 211603, 1727259004.0677452, false, 0.0, "NATROL", "natrol" },
                    { 211757, 1727259004.0677087, false, 0.0, "FOGG", "fogg" },
                    { 212149, 1727259004.0639153, false, 0.0, "Ogx", "ogx" },
                    { 212309, 1727259004.0630479, false, 0.0, "Aligro", "aligro" },
                    { 212461, 1727259004.0795708, false, 0.0, "eData", "edata" },
                    { 212575, 1727259004.0760808, false, 0.0, "YAMATO", "yamato" },
                    { 212611, 1727259004.0742023, false, 0.0, "Chicco", "chicco" },
                    { 212647, 1727259004.0772505, false, 0.0, "SMY", "smy" },
                    { 213121, 1727259004.0709288, false, 0.0, "Mustela", "mustela" },
                    { 213307, 1727259004.0834672, false, 0.0, "Kobayashi", "kobayashi" },
                    { 213397, 1727259004.065984, false, 0.0, "Medela", "medela" },
                    { 213457, 1727259004.0848365, false, 0.0, "Việt Nhật", "viet-nhat" },
                    { 213569, 1727259004.0695755, false, 0.0, "Redwin", "redwin" },
                    { 213611, 1727259004.0846684, false, 0.0, "HAKAWA", "hakawa" },
                    { 214387, 1727259004.065511, false, 0.0, "Sabina", "sabina" },
                    { 214705, 1727259004.0847511, false, 0.0, "ASOHA", "asoha" },
                    { 215649, 1727259004.0760093, false, 0.0, "JOBST", "jobst" },
                    { 215859, 1727259004.0771756, false, 0.0, "MH", "mh" },
                    { 216511, 1727259004.0666025, false, 0.0, "OLO", "olo" },
                    { 216657, 1727259004.0848267, false, 0.0, "KONKA", "konka" },
                    { 216771, 1727259004.0611131, false, 0.0, "Uniden", "uniden" },
                    { 217135, 1727259004.0648987, false, 0.0, "Ajinomoto", "ajinomoto" },
                    { 217293, 1727259004.0784545, false, 0.0, "morphy richards", "morphy-richards" },
                    { 217465, 1727259004.063292, false, 0.0, "SaChi", "sachi" },
                    { 217549, 1727259004.0751235, false, 0.0, "3CE", "3ce" },
                    { 217621, 1727259004.0725572, false, 0.0, "LAVA", "lava" },
                    { 217627, 1727259004.0790424, false, 0.0, "OPC", "opc" },
                    { 217777, 1727259004.0638747, false, 0.0, "Hatomugi", "hatomugi" },
                    { 218061, 1727259004.0615909, false, 0.0, "Halio", "halio" },
                    { 218129, 1727259004.0796144, false, 0.0, "Goldseee", "goldseee" },
                    { 218757, 1727259004.0855384, false, 0.0, "EMWEAR", "emwear" },
                    { 218953, 1727259004.0787504, false, 0.0, "Routine", "routine" },
                    { 218957, 1727259004.0705764, false, 0.0, "Healthaid", "healthaid" },
                    { 219625, 1727259004.0686791, false, 0.0, "AN BÌNH", "an-binh" },
                    { 219695, 1727259004.0651631, false, 0.0, "CAROLINE", "caroline" },
                    { 219855, 1727259004.084151, false, 0.0, "Kosé", "kose" },
                    { 219929, 1727259004.0655043, false, 0.0, "CITYMEN", "citymen" },
                    { 220219, 1727259004.0701628, false, 0.0, "ASUKA", "asuka" },
                    { 220727, 1727259004.0657959, false, 0.0, "ĐỒ DA THÀNH LONG TLG", "do-da-thanh-long-tlg" },
                    { 220831, 1727259004.0771821, false, 0.0, "Waterpulse", "waterpulse" },
                    { 221061, 1727259004.0620508, false, 0.0, "BIGGBEN", "biggben" },
                    { 221187, 1727259004.0664573, false, 0.0, "COCAYHOALA", "cocayhoala" },
                    { 221573, 1727259004.0628803, false, 0.0, "Amazing", "amazing" },
                    { 222115, 1727259004.0627823, false, 0.0, "Heliocare", "heliocare" },
                    { 222659, 1727259004.0808392, false, 0.0, "Elly", "elly" },
                    { 223153, 1727259004.0811074, false, 0.0, "JEX", "jex" },
                    { 223155, 1727259004.0744593, false, 0.0, "ONETOUCH", "onetouch" },
                    { 223635, 1727259004.0639255, false, 0.0, "Versace", "versace" },
                    { 223749, 1727259004.0803239, false, 0.0, "FIXDERMA", "fixderma" },
                    { 224217, 1727259004.0771539, false, 0.0, "Mộc Mây", "moc-may" },
                    { 224521, 1727259004.0619552, false, 0.0, "Doka", "doka" },
                    { 225531, 1727259004.0847988, false, 0.0, "PHẠM GIA ", "pham-gia" },
                    { 225581, 1727259004.0842028, false, 0.0, "ON CALL PLUS", "on-call-plus" },
                    { 226157, 1727259004.0814676, false, 0.0, "CM", "cm" },
                    { 226165, 1727259004.068114, false, 0.0, "KENDO", "kendo" },
                    { 226347, 1727259004.080466, false, 0.0, "De Leah", "de-leah" },
                    { 226669, 1727259004.0618532, false, 0.0, "Azuno", "azuno" },
                    { 226933, 1727259004.0709519, false, 0.0, "ABA", "aba" },
                    { 227783, 1727259004.0695789, false, 0.0, "AN'Sw", "an-sw" },
                    { 227935, 1727259004.0771272, false, 0.0, "Focallure", "focallure" },
                    { 227957, 1727259004.0704408, false, 0.0, "HECTOR", "hector" },
                    { 229403, 1727259004.0728326, false, 0.0, "L'ocean", "l-ocean" },
                    { 229559, 1727259004.0692785, false, 0.0, "Panda Baby", "panda-baby" },
                    { 230695, 1727259004.0613043, false, 0.0, "CHOYA", "choya" },
                    { 231125, 1727259004.0763752, false, 0.0, "Trường Hải", "truong-hai" },
                    { 231297, 1727259004.0696683, false, 0.0, "HONEYLAND", "honeyland" },
                    { 231725, 1727259004.0735018, false, 0.0, "Sunbaby", "sunbaby" },
                    { 231755, 1727259004.0816653, false, 0.0, "Okazaki", "okazaki" },
                    { 232191, 1727259004.0625761, false, 0.0, "Bourbon", "bourbon" },
                    { 232797, 1727259004.0829215, false, 0.0, "USP", "usp" },
                    { 232949, 1727259004.0833549, false, 0.0, "Nutricia", "nutricia" },
                    { 233529, 1727259004.0672269, false, 0.0, "Nature's Way", "nature-s-way" },
                    { 234331, 1727259004.0664806, false, 0.0, "beauty garden", "beauty-garden" },
                    { 234665, 1727259004.0696452, false, 0.0, "H2ofloss", "h2ofloss" },
                    { 235231, 1727259004.0823655, false, 0.0, "OLEO", "oleo" },
                    { 235455, 1727259004.0718825, false, 0.0, "Li Chuan", "li-chuan" },
                    { 235517, 1727259004.081049, false, 0.0, "MoriS", "moris" },
                    { 235869, 1727259004.0729327, false, 0.0, "DR.BEI", "dr-bei" },
                    { 235879, 1727259004.0771081, false, 0.0, "TETE", "tete" },
                    { 236941, 1727259004.0828607, false, 0.0, "MẸ KEN", "me-ken" },
                    { 237931, 1727259004.0612793, false, 0.0, "Asahi", "asahi" },
                    { 238003, 1727259004.0790005, false, 0.0, "Thanh Mộc Hương", "thanh-moc-huong" },
                    { 238407, 1727259004.0705376, false, 0.0, "Oribe", "oribe" },
                    { 238725, 1727259004.0664904, false, 0.0, "Cottage", "cottage" },
                    { 238861, 1727259004.0638983, false, 0.0, "TSUBAKI", "tsubaki" },
                    { 239327, 1727259004.0746624, false, 0.0, "Speedo", "speedo" },
                    { 240279, 1727259004.0755496, false, 0.0, "Owen", "owen" },
                    { 240925, 1727259004.0657728, false, 0.0, "Biti's", "biti-s" },
                    { 241131, 1727259004.0705516, false, 0.0, "ORBE", "orbe" },
                    { 242001, 1727259004.0816884, false, 0.0, "Ya-man", "ya-man" },
                    { 242445, 1727259004.0822592, false, 0.0, "Tâm Minh Foods", "tam-minh-foods" },
                    { 242929, 1727259004.0827634, false, 0.0, "Dalahouse", "dalahouse" },
                    { 244305, 1727259004.061784, false, 0.0, "GOTI", "goti" },
                    { 244351, 1727259004.0716939, false, 0.0, "Fine Japan", "fine-japan" },
                    { 245085, 1727259004.0661612, false, 0.0, "Dori", "dori" },
                    { 245913, 1727259004.0687253, false, 0.0, "KONKA-1", "konka-1" },
                    { 245945, 1727259004.066582, false, 0.0, "miDoctor", "midoctor" },
                    { 245967, 1727259004.0677519, false, 0.0, "VIETNAT ", "vietnat" },
                    { 246545, 1727259004.0641921, false, 0.0, "dokafashion", "dokafashion" },
                    { 246571, 1727259004.0652752, false, 0.0, "GH Creation", "gh-creation" },
                    { 247549, 1727259004.0645716, false, 0.0, "Realme", "realme" },
                    { 248041, 1727259004.0615623, false, 0.0, "Antiphlamine", "antiphlamine" },
                    { 248191, 1727259004.065186, false, 0.0, "Weilaiya", "weilaiya" },
                    { 248385, 1727259004.0789876, false, 0.0, "24Care", "24care" },
                    { 248413, 1727259004.0642996, false, 0.0, "Haint Boutique", "haint-boutique" },
                    { 250517, 1727259004.0624712, false, 0.0, "Đức", "duc" },
                    { 250531, 1727259004.066474, false, 0.0, "Some By Mi", "some-by-mi" },
                    { 251107, 1727259004.0706091, false, 0.0, "Eucryl", "eucryl" },
                    { 251807, 1727259004.0796399, false, 0.0, "Schiff", "schiff" },
                    { 252095, 1727259004.0794244, false, 0.0, "ILDONG", "ildong" },
                    { 252399, 1727259004.0645616, false, 0.0, "A", "a" },
                    { 252859, 1727259004.0759058, false, 0.0, "MayCreate", "maycreate" },
                    { 253361, 1727259004.0695724, false, 0.0, "BEBU", "bebu" },
                    { 253901, 1727259004.0765927, false, 0.0, "MH SAIGON", "mh-saigon" },
                    { 254331, 1727259004.0657196, false, 0.0, "ONOFF", "onoff" },
                    { 254677, 1727259004.0835075, false, 0.0, "ANNA SUI", "anna-sui" },
                    { 254939, 1727259004.0835462, false, 0.0, "Nikita", "nikita" },
                    { 255655, 1727259004.0817075, false, 0.0, "Nadamcos", "nadamcos" },
                    { 255883, 1727259004.0800471, false, 0.0, "Desmiit", "desmiit" },
                    { 257147, 1727259004.0842063, false, 0.0, "mona", "mona" },
                    { 257373, 1727259004.0736637, false, 0.0, "FEG", "feg" },
                    { 257401, 1727259004.0646787, false, 0.0, "Grandstream", "grandstream" },
                    { 258537, 1727259004.0638511, false, 0.0, "Too Cool For School", "too-cool-for-school" },
                    { 258553, 1727259004.0695925, false, 0.0, "DELOFIL PROFESSIONAL", "delofil-professional" },
                    { 259015, 1727259004.0801332, false, 0.0, "Brauer", "brauer" },
                    { 259021, 1727259004.0705667, false, 0.0, "Medivistar", "medivistar" },
                    { 259307, 1727259004.0729234, false, 0.0, "Hendel", "hendel" },
                    { 259827, 1727259004.0841312, false, 0.0, "Youtheory", "youtheory" },
                    { 260977, 1727259004.0766027, false, 0.0, "Daedong Korea Ginseng", "daedong-korea-ginseng" },
                    { 261107, 1727259004.0658159, false, 0.0, "Comfybaby", "comfybaby" },
                    { 261245, 1727259004.0631697, false, 0.0, "GIFT", "gift" },
                    { 261801, 1727259004.0631199, false, 0.0, "Leman", "leman" },
                    { 261827, 1727259004.0733306, false, 0.0, "PGM", "pgm" },
                    { 261975, 1727259004.0735145, false, 0.0, "Duka", "duka" },
                    { 262161, 1727259004.0823314, false, 0.0, "Mochi", "mochi" },
                    { 270981, 1727259004.0828829, false, 0.0, "Thái Dương", "thai-duong" },
                    { 271349, 1727259004.0643096, false, 0.0, "Monobo", "monobo" },
                    { 271571, 1727259004.06652, false, 0.0, "LATINO", "latino" },
                    { 272309, 1727259004.0740855, false, 0.0, "Sport", "sport" },
                    { 272809, 1727259004.0796676, false, 0.0, "Kipor", "kipor" },
                    { 272829, 1727259004.0853713, false, 0.0, "Nano AHT", "nano-aht" },
                    { 273281, 1727259004.0664837, false, 0.0, "Bio-Oil", "bio-oil" },
                    { 273321, 1727259004.0721157, false, 0.0, "Vitatree", "vitatree" },
                    { 273525, 1727259004.0752127, false, 0.0, "Aura", "aura" },
                    { 273717, 1727259004.0619013, false, 0.0, "GOKING", "goking" },
                    { 273971, 1727259004.06864, false, 0.0, "Laurier", "laurier" },
                    { 274043, 1727259004.08002, false, 0.0, "Vincy", "vincy" },
                    { 274275, 1727259004.0617063, false, 0.0, "May 10", "may-10" },
                    { 275037, 1727259004.0659907, false, 0.0, "Maymom", "maymom" },
                    { 275197, 1727259004.0676887, false, 0.0, "Apestomen", "apestomen" },
                    { 276747, 1727259004.0650625, false, 0.0, "Perspirex ", "perspirex" },
                    { 279601, 1727259004.0692046, false, 0.0, "Metacare", "metacare" },
                    { 280113, 1727259004.0759404, false, 0.0, "Cao Gừng", "cao-gung" },
                    { 280165, 1727259004.06862, false, 0.0, "Browit", "browit" },
                    { 280167, 1727259004.0802524, false, 0.0, "Lameila", "lameila" },
                    { 280349, 1727259004.0639544, false, 0.0, "Aspor", "aspor" },
                    { 281391, 1727259004.0633292, false, 0.0, "HANET", "hanet" },
                    { 282013, 1727259004.0627296, false, 0.0, "Kukobo", "kukobo" },
                    { 282637, 1727259004.0654082, false, 0.0, "ZART", "zart" },
                    { 282805, 1727259004.0737054, false, 0.0, "United Medicare", "united-medicare" },
                    { 283249, 1727259004.0771635, false, 0.0, "ELGON", "elgon" },
                    { 283595, 1727259004.0759528, false, 0.0, "BRITISH M", "british-m" },
                    { 283985, 1727259004.0676761, false, 0.0, "Kevin.murphy", "kevin-murphy" },
                    { 284315, 1727259004.065176, false, 0.0, "Karseell", "karseell" },
                    { 288115, 1727259004.0676191, false, 0.0, "CHANEL", "chanel" },
                    { 290155, 1727259004.0854375, false, 0.0, "Tangle Teezer", "tangle-teezer" },
                    { 292285, 1727259004.0720673, false, 0.0, "KUROBARA", "kurobara" },
                    { 293033, 1727259004.0803058, false, 0.0, "Krishna", "krishna" },
                    { 293765, 1727259004.0627401, false, 0.0, "Dạ Thảo Liên", "da-thao-lien" },
                    { 294011, 1727259004.063015, false, 0.0, "SITAKI", "sitaki" },
                    { 294433, 1727259004.0676429, false, 0.0, "Lemonade", "lemonade" },
                    { 295203, 1727259004.0760496, false, 0.0, "FUJIKA", "fujika" },
                    { 296783, 1727259004.0796175, false, 0.0, "ON&ON", "on-on" },
                    { 297957, 1727259004.0702353, false, 0.0, "VIJAGO", "vijago" },
                    { 298405, 1727259004.0705547, false, 0.0, "DCYTLOC", "dcytloc" },
                    { 298837, 1727259004.0800834, false, 0.0, "zahan", "zahan" },
                    { 299381, 1727259004.0692213, false, 0.0, "Kabrita", "kabrita" },
                    { 300165, 1727259004.0665469, false, 0.0, "Freelander", "freelander" },
                    { 300463, 1727259004.0819471, false, 0.0, "MLB", "mlb" },
                    { 306897, 1727259004.0810945, false, 0.0, "Nature's Bounty", "nature-s-bounty" },
                    { 307531, 1727259004.0803444, false, 0.0, "O'2nails", "o-2nails" },
                    { 307609, 1727259004.0638845, false, 0.0, "Neutrogena", "neutrogena" },
                    { 308227, 1727259004.0790329, false, 0.0, "Mật Ong Phúc Khang", "mat-ong-phuc-khang" },
                    { 308811, 1727259004.0662751, false, 0.0, "EBARA", "ebara" },
                    { 310475, 1727259004.0612364, false, 0.0, "Meadow Fresh", "meadow-fresh" },
                    { 311171, 1727259004.0691755, false, 0.0, "Abbott Grow", "abbott-grow" },
                    { 314409, 1727259004.0676959, false, 0.0, "TIGI", "tigi" },
                    { 314973, 1727259004.0665233, false, 0.0, "Jean Paul Gaultier", "jean-paul-gaultier" },
                    { 317315, 1727259004.0751176, false, 0.0, "ETIAXIL", "etiaxil" },
                    { 317963, 1727259004.0620244, false, 0.0, "N6", "n6" },
                    { 317995, 1727259004.0608871, false, 0.0, "QMAN", "qman" },
                    { 318289, 1727259004.0828955, false, 0.0, "TRUSSARDI", "trussardi" },
                    { 321545, 1727259004.0627198, false, 0.0, "BELIPS", "belips" },
                    { 324087, 1727259004.0641689, false, 0.0, "LQ luxury", "lq-luxury" },
                    { 324135, 1727259004.085418, false, 0.0, "Lam Mộc", "lam-moc" },
                    { 325063, 1727259004.0756371, false, 0.0, "Native", "native" },
                    { 326649, 1727259004.084748, false, 0.0, "Ihomeda", "ihomeda" },
                    { 327043, 1727259004.0638344, false, 0.0, "OFÉLIA", "ofelia" },
                    { 327861, 1727259004.0829785, false, 0.0, "PURE", "pure" },
                    { 330843, 1727259004.0792291, false, 0.0, "HATI", "hati" },
                    { 331895, 1727259004.0705962, false, 0.0, "Feel", "feel" },
                    { 332519, 1727259004.063818, false, 0.0, "CeraVe", "cerave" },
                    { 354595, 1727259004.0614192, false, 0.0, "Old Spice", "old-spice" },
                    { 354683, 1727259004.0636189, false, 0.0, "Barona", "barona" },
                    { 355081, 1727259004.0639679, false, 0.0, "ferourdex", "ferourdex" },
                    { 355755, 1727259004.0832777, false, 0.0, "BEPANTHEN", "bepanthen" },
                    { 360931, 1727259004.0795927, false, 0.0, "Bioaqua", "bioaqua" },
                    { 362753, 1727259004.0644753, false, 0.0, "NAVAN ", "navan" },
                    { 364377, 1727259004.0608201, false, 0.0, "DK Pharma", "dk-pharma" },
                    { 366783, 1727259004.0817041, false, 0.0, "BioHealth", "biohealth" },
                    { 367577, 1727259004.0854597, false, 0.0, "TERESA HERBS ", "teresa-herbs" },
                    { 367697, 1727259004.0695891, false, 0.0, "Sophia", "sophia" },
                    { 367883, 1727259004.0648148, false, 0.0, "Louis Rice", "louis-rice" },
                    { 367991, 1727259004.0736701, false, 0.0, "Lana", "lana" },
                    { 368153, 1727259004.083792, false, 0.0, "MAXIVIC", "maxivic" },
                    { 369051, 1727259004.0652952, false, 0.0, "Doublesafe", "doublesafe" },
                    { 370261, 1727259004.0673664, false, 0.0, "HiSEA", "hisea" },
                    { 370343, 1727259004.0783596, false, 0.0, "Obsidian", "obsidian" },
                    { 370411, 1727259004.0782309, false, 0.0, "BENRIKIDS", "benrikids" },
                    { 370597, 1727259004.0832405, false, 0.0, "AONIJIE", "aonijie" },
                    { 370685, 1727259004.0701156, false, 0.0, "Longlife", "longlife" },
                    { 370711, 1727259004.067739, false, 0.0, "Sinocare", "sinocare" },
                    { 372895, 1727259004.0704677, false, 0.0, "Cỏ Mềm", "co-mem" },
                    { 373289, 1727259004.0775225, false, 0.0, "WINFA", "winfa" },
                    { 373379, 1727259004.0651064, false, 0.0, "HUYEN PHI COSMETICS", "huyen-phi-cosmetics" },
                    { 402501, 1727259004.0721684, false, 0.0, "CYKE ", "cyke" },
                    { 403327, 1727259004.0757048, false, 0.0, "Livedo", "livedo" },
                    { 403371, 1727259004.0626843, false, 0.0, "DTfood", "dtfood" },
                    { 404719, 1727259004.0777423, false, 0.0, "YSL", "ysl" },
                    { 406479, 1727259004.0810685, false, 0.0, "Nashi", "nashi" },
                    { 406575, 1727259004.0609517, false, 0.0, "POCO", "poco" },
                    { 406759, 1727259004.0614357, false, 0.0, "Hensley", "hensley" },
                    { 407603, 1727259004.0823145, false, 0.0, "Acosmetics", "acosmetics" },
                    { 408085, 1727259004.0733242, false, 0.0, "Fila", "fila" },
                    { 409613, 1727259004.0829911, false, 0.0, "Tanmy Design", "tanmy-design" },
                    { 410547, 1727259004.0777688, false, 0.0, "WELLA", "wella" },
                    { 411201, 1727259004.0757675, false, 0.0, "Natrumax", "natrumax" },
                    { 411395, 1727259004.0673428, false, 0.0, "ARO", "aro" },
                    { 411497, 1727259004.0762997, false, 0.0, "BIGFOX", "bigfox" },
                    { 411531, 1727259004.0628638, false, 0.0, "ARCTIC HUNTER", "arctic-hunter" },
                    { 411791, 1727259004.0627327, false, 0.0, "Tesori D'Oriente", "tesori-d-oriente" },
                    { 413145, 1727259004.0702822, false, 0.0, "MITU", "mitu" },
                    { 413203, 1727259004.0846651, false, 0.0, "Hạnh Dương", "hanh-duong" },
                    { 415201, 1727259004.0815425, false, 0.0, "HakuBaku", "hakubaku" },
                    { 415523, 1727259004.0854061, false, 0.0, "confume", "confume" },
                    { 415605, 1727259004.0692515, false, 0.0, "Detech Bio", "detech-bio" },
                    { 415739, 1727259004.0651827, false, 0.0, "Mugens", "mugens" },
                    { 416127, 1727259004.0676329, false, 0.0, "the history of whoo", "the-history-of-whoo" },
                    { 416527, 1727259004.0783565, false, 0.0, "legitime", "legitime" },
                    { 416589, 1727259004.0709686, false, 0.0, "EcoClean ", "ecoclean" },
                    { 416995, 1727259004.0749986, false, 0.0, "Shalla", "shalla" },
                    { 417077, 1727259004.0751841, false, 0.0, "HUY NAM", "huy-nam" },
                    { 417425, 1727259004.0781105, false, 0.0, "MĐ", "md" },
                    { 418769, 1727259004.074146, false, 0.0, "Calosure Gold", "calosure-gold" },
                    { 418935, 1727259004.0631168, false, 0.0, "KHATOCO ", "khatoco" },
                    { 419033, 1727259004.0795832, false, 0.0, "AQUAVERA", "aquavera" },
                    { 419037, 1727259004.0677848, false, 0.0, "PIERROT", "pierrot" },
                    { 419263, 1727259004.0634043, false, 0.0, "Likebook", "likebook" },
                    { 421185, 1727259004.0615938, false, 0.0, " SOKANY", "sokany" },
                    { 421895, 1727259004.0808585, false, 0.0, "ColosBaby", "colosbaby" },
                    { 422141, 1727259004.0841768, false, 0.0, "Mộc An", "moc-an" },
                    { 423721, 1727259004.0626516, false, 0.0, "x", "x" },
                    { 424081, 1727259004.0853741, false, 0.0, "Lynan", "lynan" },
                    { 424177, 1727259004.0766125, false, 0.0, "HONIMORE", "honimore" },
                    { 424503, 1727259004.0807943, false, 0.0, "Seobean", "seobean" },
                    { 425425, 1727259004.0668461, false, 0.0, "Kun93", "kun93" },
                    { 425555, 1727259004.0751266, false, 0.0, "F.O.X", "f-o-x" },
                    { 426403, 1727259004.0645483, false, 0.0, "Mideer", "mideer" },
                    { 426989, 1727259004.0853937, false, 0.0, "New Moon", "new-moon" },
                    { 427231, 1727259004.0662615, false, 0.0, "SAHU", "sahu" },
                    { 427499, 1727259004.0728619, false, 0.0, "Watsons", "watsons" },
                    { 429751, 1727259004.0751746, false, 0.0, "ELDAS", "eldas" },
                    { 432517, 1727259004.0676126, false, 0.0, "Canmake", "canmake" },
                    { 432829, 1727259004.0789845, false, 0.0, "Livegain", "livegain" },
                    { 443303, 1727259004.063266, false, 0.0, "Boost", "boost" },
                    { 444413, 1727259004.0782053, false, 0.0, "APPETON", "appeton" },
                    { 445011, 1727259004.0695825, false, 0.0, "malizia", "malizia" },
                    { 448533, 1727259004.0759342, false, 0.0, "Men Stay Simplicity", "men-stay-simplicity" },
                    { 448813, 1727259004.0619221, false, 0.0, "CATRIO", "catrio" },
                    { 449693, 1727259004.0652783, false, 0.0, "Healthy Care", "healthy-care" },
                    { 451273, 1727259004.0691979, false, 0.0, "Aiko", "aiko" },
                    { 452849, 1727259004.067277, false, 0.0, "Dnee", "dnee" },
                    { 454251, 1727259004.0609045, false, 0.0, "QuickStick", "quickstick" },
                    { 454561, 1727259004.0665169, false, 0.0, "KOMI", "komi" },
                    { 454665, 1727259004.0789428, false, 0.0, "Ecocare", "ecocare" },
                    { 455535, 1727259004.0831449, false, 0.0, "Valentino Creations", "valentino-creations" },
                    { 455955, 1727259004.0751679, false, 0.0, "Perfume Generics", "perfume-generics" },
                    { 456351, 1727259004.0750177, false, 0.0, "Amalife", "amalife" },
                    { 456513, 1727259004.0790875, false, 0.0, "KHONCC", "khoncc" },
                    { 460341, 1727259004.0700731, false, 0.0, "Vascara", "vascara" },
                    { 463979, 1727259004.0683925, false, 0.0, "SÀI THÀNH FOODS", "sai-thanh-foods" },
                    { 466043, 1727259004.0725372, false, 0.0, "Special Kid", "special-kid" },
                    { 467717, 1727259004.084254, false, 0.0, "FORSETI", "forseti" },
                    { 469073, 1727259004.0717499, false, 0.0, "Nutrimilk", "nutrimilk" },
                    { 469121, 1727259004.0789199, false, 0.0, "LANGCE", "langce" },
                    { 470537, 1727259004.067699, false, 0.0, "Lavox", "lavox" },
                    { 470751, 1727259004.0828669, false, 0.0, "Mr.fresh", "mr-fresh" },
                    { 471259, 1727259004.0794213, false, 0.0, "BEBEDANG", "bebedang" },
                    { 471575, 1727259004.0686297, false, 0.0, "Himalaya Since 1930", "himalaya-since-1930" },
                    { 471779, 1727259004.0638278, false, 0.0, "nuxe paris", "nuxe-paris" },
                    { 472079, 1727259004.063467, false, 0.0, "Yealink", "yealink" },
                    { 475611, 1727259004.0855255, false, 0.0, "jichen", "jichen" },
                    { 476013, 1727259004.06686, false, 0.0, "jones'.", "jones" },
                    { 476175, 1727259004.0769978, false, 0.0, "umoo", "umoo" },
                    { 477307, 1727259004.0629854, false, 0.0, "MXM", "mxm" },
                    { 478375, 1727259004.0749955, false, 0.0, "Holla", "holla" },
                    { 478795, 1727259004.0683296, false, 0.0, "Fatz Baby", "fatz-baby" },
                    { 480567, 1727259004.0769455, false, 0.0, "Hương quế", "huong-que" },
                    { 480737, 1727259004.0760465, false, 0.0, "Median", "median" },
                    { 481069, 1727259004.0644789, false, 0.0, "MinPrice MinPrice", "min-min" },
                    { 481817, 1727259004.0749445, false, 0.0, "Grainlife", "grainlife" },
                    { 484559, 1727259004.0665069, false, 0.0, "head and shoulders", "head-and-shoulders" },
                    { 484905, 1727259004.0795987, false, 0.0, "MASARONI", "masaroni" },
                    { 485389, 1727259004.0853617, false, 0.0, "naturaglacé", "naturaglace" },
                    { 486871, 1727259004.0658977, false, 0.0, "natures aid", "natures-aid" },
                    { 486873, 1727259004.0803149, false, 0.0, "batiste", "batiste" },
                    { 486937, 1727259004.0728393, false, 0.0, "catrice", "catrice" },
                    { 486953, 1727259004.0650995, false, 0.0, "labocare", "labocare" },
                    { 487641, 1727259004.0836325, false, 0.0, "4lova", "4lova" },
                    { 487661, 1727259004.0806658, false, 0.0, "LAROMA FASHION", "laroma-fashion" },
                    { 488103, 1727259004.061908, false, 0.0, "MRM Manlywear", "mrm-manlywear" },
                    { 488701, 1727259004.0772471, false, 0.0, "Daikiosan", "daikiosan" },
                    { 490423, 1727259004.0834892, false, 0.0, "LORITA", "lorita" },
                    { 491699, 1727259004.0760436, false, 0.0, "Closeup", "closeup" },
                    { 491887, 1727259004.0705829, false, 0.0, "one a day", "one-a-day" },
                    { 493435, 1727259004.0695434, false, 0.0, "homer", "homer" },
                    { 493923, 1727259004.0783136, false, 0.0, "Pourto", "pourto" },
                    { 493985, 1727259004.0705309, false, 0.0, "OGX Beauty", "ogx-beauty" },
                    { 494763, 1727259004.0620277, false, 0.0, "Fasvin", "fasvin" },
                    { 495439, 1727259004.0645311, false, 0.0, "sudocrem", "sudocrem" },
                    { 495465, 1727259004.0644822, false, 0.0, "bioisland", "bioisland" },
                    { 496813, 1727259004.0620439, false, 0.0, "buybox", "buybox" },
                    { 497361, 1727259004.0775988, false, 0.0, "Dimao", "dimao" },
                    { 499597, 1727259004.0613308, false, 0.0, "Grand Castella", "grand-castella" },
                    { 501111, 1727259004.0653572, false, 0.0, "BLAUBERG", "blauberg" },
                    { 501567, 1727259004.0776117, false, 0.0, "Avisure", "avisure" },
                    { 502001, 1727259004.0673728, false, 0.0, "Tiki", "tiki" },
                    { 503605, 1727259004.0717895, false, 0.0, "Nifoki", "nifoki" },
                    { 504521, 1727259004.0621419, false, 0.0, "Elevit", "elevit" },
                    { 505165, 1727259004.0640469, false, 0.0, "Song An Eco", "song-an-eco" },
                    { 505595, 1727259004.0619416, false, 0.0, "VONESA", "vonesa" },
                    { 505859, 1727259004.0632367, false, 0.0, "Fe-NANA", "fe-nana" },
                    { 507597, 1727259004.0791032, false, 0.0, "Jindian", "jindian" },
                    { 510027, 1727259004.0765576, false, 0.0, "KIKO", "kiko" },
                    { 510303, 1727259004.0745096, false, 0.0, "codol", "codol" },
                    { 512025, 1727259004.0719192, false, 0.0, "dan.d.pak", "dan-d-pak" },
                    { 512067, 1727259004.0622177, false, 0.0, "KINGO", "kingo" },
                    { 512403, 1727259004.0810332, false, 0.0, "sidumi", "sidumi" },
                    { 517583, 1727259004.0794017, false, 0.0, "YUBEST", "yubest" },
                    { 517597, 1727259004.0771427, false, 0.0, "MIRI", "miri" },
                    { 518791, 1727259004.0636656, false, 0.0, "SUNTORY", "suntory" },
                    { 521331, 1727259004.0752511, false, 0.0, "Hera Milk", "hera-milk" },
                    { 522685, 1727259004.0623813, false, 0.0, "Flyingvoice", "flyingvoice" },
                    { 524379, 1727259004.0698304, false, 0.0, "Zento", "zento" },
                    { 525205, 1727259004.0696316, false, 0.0, "Bebird", "bebird" },
                    { 525323, 1727259004.0623715, false, 0.0, "Fanvil", "fanvil" },
                    { 529027, 1727259004.0803378, false, 0.0, "SALONLINK", "salonlink" },
                    { 532357, 1727259004.0687156, false, 0.0, "DELIYA", "deliya" },
                    { 533281, 1727259004.0822208, false, 0.0, "BIBS", "bibs" },
                    { 534007, 1727259004.0658841, false, 0.0, "Long Lien", "long-lien" },
                    { 535627, 1727259004.0630248, false, 0.0, "5S", "5s" },
                    { 537217, 1727259004.0796611, false, 0.0, "Medicare", "medicare" },
                    { 537679, 1727259004.0618627, false, 0.0, "MAYHOMES", "mayhomes" },
                    { 538093, 1727259004.0776556, false, 0.0, "Diệp Linh", "diep-linh" },
                    { 538513, 1727259004.0652387, false, 0.0, "WAHL", "wahl" },
                    { 539369, 1727259004.0777979, false, 0.0, "Betimum", "betimum" },
                    { 540977, 1727259004.069113, false, 0.0, "Viettien", "viettien" },
                    { 541293, 1727259004.068742, false, 0.0, "Enchen", "enchen" },
                    { 541755, 1727259004.0766251, false, 0.0, "Fobe", "fobe" },
                    { 542821, 1727259004.0762498, false, 0.0, "Final", "final" },
                    { 545367, 1727259004.0624909, false, 0.0, "belcube", "belcube" },
                    { 548147, 1727259004.0664272, false, 0.0, "Nivea Men", "nivea-men" },
                    { 550669, 1727259004.0659809, false, 0.0, "Zcare", "zcare" },
                    { 550967, 1727259004.0834448, false, 0.0, "Superdrug", "superdrug" },
                    { 559269, 1727259004.0815456, false, 0.0, "Imochild", "imochild" },
                    { 560095, 1727259004.0752475, false, 0.0, "Genki Fami", "genki-fami" },
                    { 560863, 1727259004.0696652, false, 0.0, "Kirkland Signature", "kirkland-signature" },
                    { 561415, 1727259004.0614913, false, 0.0, "	OEM", "oem" },
                    { 565173, 1727259004.0783226, false, 0.0, "MQ Skin", "mq-skin" },
                    { 567681, 1727259004.0662384, false, 0.0, "Casa Rinaldi", "casa-rinaldi" },
                    { 567735, 1727259004.0695364, false, 0.0, "Delverde", "delverde" },
                    { 568489, 1727259004.0736504, false, 0.0, "iCare Pharma", "icare-pharma" },
                    { 569135, 1727259004.0650795, false, 0.0, "Rejuvaskin", "rejuvaskin" },
                    { 573905, 1727259004.0686822, false, 0.0, "GACVIET", "gacviet" },
                    { 574165, 1727259004.0681529, false, 0.0, "Đông Hải", "dong-hai" },
                    { 575497, 1727259004.0702288, false, 0.0, "BABYBOSS", "babyboss" },
                    { 577937, 1727259004.083358, false, 0.0, "KOOBEME", "koobeme" },
                    { 578381, 1727259004.0801964, false, 0.0, "TOI", "toi" },
                    { 578757, 1727259004.0728943, false, 0.0, "On Call", "on-call" },
                    { 578825, 1727259004.0733752, false, 0.0, "CHRISTINA-Q", "christina-q" },
                    { 578915, 1727259004.0666664, false, 0.0, "OLAPLE", "olaple" },
                    { 579399, 1727259004.083626, false, 0.0, "REKKY", "rekky" },
                    { 579813, 1727259004.0731969, false, 0.0, " OEM", "oem" },
                    { 580445, 1727259004.0847323, false, 0.0, "Yuwa", "yuwa" },
                    { 592473, 1727259004.0693631, false, 0.0, "RICA", "rica" },
                    { 601177, 1727259004.0665655, false, 0.0, "TTGloves", "ttgloves" },
                    { 602331, 1727259004.0757639, false, 0.0, "MaxPrice Biocare", "max-biocare" },
                    { 602421, 1727259004.0853586, false, 0.0, "BLACKROUGE", "blackrouge" },
                    { 606243, 1727259004.0677359, false, 0.0, "NeilMed", "neilmed" },
                    { 606305, 1727259004.0705698, false, 0.0, "DAICAT", "daicat" },
                    { 607117, 1727259004.0725763, false, 0.0, "Magcaldi", "magcaldi" },
                    { 608901, 1727259004.0612659, false, 0.0, "Bonzon", "bonzon" },
                    { 609131, 1727259004.076638, false, 0.0, "Bcook", "bcook" },
                    { 609185, 1727259004.0653355, false, 0.0, "B.COOK", "b-cook" },
                    { 609663, 1727259004.060837, false, 0.0, "Pregnacare", "pregnacare" },
                    { 609665, 1727259004.0801744, false, 0.0, "Hegen", "hegen" },
                    { 609669, 1727259004.0781701, false, 0.0, "Momorabbit", "momorabbit" },
                    { 609995, 1727259004.0788076, false, 0.0, "IgYGate", "igygate" },
                    { 611917, 1727259004.0775068, false, 0.0, "Mirato", "mirato" },
                    { 612941, 1727259004.0671177, false, 0.0, "TLG Thành Long", "tlg-thanh-long" },
                    { 612965, 1727259004.0760059, false, 0.0, "Anyguard", "anyguard" },
                    { 613101, 1727259004.0789328, false, 0.0, "CARE:NEL", "care-nel" },
                    { 613493, 1727259004.0648952, false, 0.0, "Làng Chài Xưa", "lang-chai-xua" },
                    { 616323, 1727259004.0725183, false, 0.0, "CANNY", "canny" },
                    { 617801, 1727259004.0806756, false, 0.0, "Andromeda", "andromeda" },
                    { 617833, 1727259004.060894, false, 0.0, "TP Tiến Phát SMART", "tp-tien-phat-smart" },
                    { 618505, 1727259004.0666261, false, 0.0, "White And White", "white-and-white" },
                    { 618559, 1727259004.0656309, false, 0.0, "Nexx & Dee", "nexx-dee" },
                    { 621539, 1727259004.0621486, false, 0.0, "ROYAL AUSNZ", "royal-ausnz" },
                    { 625901, 1727259004.0758364, false, 0.0, "Hosna Tunisia", "hosna-tunisia" },
                    { 626025, 1727259004.0842192, false, 0.0, "Nature's Top", "nature-s-top" },
                    { 626085, 1727259004.0759089, false, 0.0, "JUDYDOLL", "judydoll" },
                    { 626253, 1727259004.0743921, false, 0.0, "Nakiz", "nakiz" },
                    { 626819, 1727259004.0651164, false, 0.0, "PEACE MASS", "peace-mass" },
                    { 626999, 1727259004.0770822, false, 0.0, "Bonchi", "bonchi" },
                    { 628517, 1727259004.0764244, false, 0.0, "AN CỐT ĐAN", "an-cot-dan" },
                    { 629125, 1727259004.0822113, false, 0.0, "ĐQVIN PHARMA", "dqvin-pharma" },
                    { 629451, 1727259004.0783105, false, 0.0, "Dolly Wink", "dolly-wink" },
                    { 630655, 1727259004.0643845, false, 0.0, "Mijuku", "mijuku" },
                    { 631569, 1727259004.0615971, false, 0.0, "KINGTECH", "kingtech" },
                    { 632045, 1727259004.0809193, false, 0.0, "Okawari", "okawari" },
                    { 632083, 1727259004.07952, false, 0.0, "Daishou", "daishou" },
                    { 632569, 1727259004.0801613, false, 0.0, "Hoàng Huy Organic", "hoang-huy-organic" },
                    { 632589, 1727259004.0736735, false, 0.0, "Sinh Dược", "sinh-duoc" },
                    { 632677, 1727259004.0628133, false, 0.0, "SEKA", "seka" },
                    { 632685, 1727259004.0664673, false, 0.0, "DEGREE", "degree" },
                    { 633815, 1727259004.0816779, false, 0.0, "L'Oreal Professionnel", "l-oreal-professionnel" },
                    { 634333, 1727259004.0829816, false, 0.0, "Doux", "doux" },
                    { 636085, 1727259004.0682871, false, 0.0, "Everyday Health", "everyday-health" },
                    { 639127, 1727259004.0677123, false, 0.0, "MORRA", "morra" },
                    { 643749, 1727259004.062758, false, 0.0, "JAGUAR", "jaguar" },
                    { 660343, 1727259004.0828154, false, 0.0, "LEGO DUPLO", "lego-duplo" },
                    { 664703, 1727259004.0617807, false, 0.0, "ĐŨI VIỆT", "dui-viet" },
                    { 675091, 1727259004.0702384, false, 0.0, "Woim", "woim" },
                    { 684889, 1727259004.0771396, false, 0.0, "EUBOS", "eubos" },
                    { 685413, 1727259004.0744467, false, 0.0, "Make It Real", "make-it-real" },
                    { 685825, 1727259004.0609181, false, 0.0, "Tín Phong", "tin-phong" },
                    { 686807, 1727259004.0668364, false, 0.0, "ZOJ", "zoj" },
                    { 687857, 1727259004.0625372, false, 0.0, "AGF", "agf" },
                    { 688007, 1727259004.0762119, false, 0.0, "Dottie", "dottie" },
                    { 689147, 1727259004.0789168, false, 0.0, "YumeiSakura", "yumeisakura" },
                    { 690863, 1727259004.0760746, false, 0.0, "ERA", "era" },
                    { 693507, 1727259004.0623946, false, 0.0, "HALONG CANFOCO", "halong-canfoco" },
                    { 694491, 1727259004.0631664, false, 0.0, "WINKA", "winka" },
                    { 695741, 1727259004.0744233, false, 0.0, "AL-REHAB", "al-rehab" },
                    { 700025, 1727259004.0771885, false, 0.0, "Dược Bình Đông", "duoc-binh-dong" },
                    { 701701, 1727259004.0764532, false, 0.0, "TIASANG", "tiasang" },
                    { 706971, 1727259004.0664968, false, 0.0, "Aroma Works", "aroma-works" },
                    { 707789, 1727259004.062084, false, 0.0, "LINEABON", "lineabon" },
                    { 707795, 1727259004.0849757, false, 0.0, "PINKSTULL", "pinkstull" },
                    { 707989, 1727259004.0704975, false, 0.0, "ECODEALS", "ecodeals" },
                    { 713343, 1727259004.0829277, false, 0.0, "Gilaa", "gilaa" },
                    { 713425, 1727259004.0775828, false, 0.0, "Ecowipes", "ecowipes" },
                    { 713471, 1727259004.0692751, false, 0.0, "Babyup", "babyup" },
                    { 716223, 1727259004.0705109, false, 0.0, "Showemate", "showemate" },
                    { 716275, 1727259004.0636854, false, 0.0, "Cocon", "cocon" },
                    { 717665, 1727259004.0701289, false, 0.0, "UC2", "uc2" },
                    { 718933, 1727259004.0630376, false, 0.0, "ARADO FASHION", "arado-fashion" },
                    { 720587, 1727259004.0816529, false, 0.0, "MEKOFARM", "mekofarm" },
                    { 722995, 1727259004.0752444, false, 0.0, "QIK HAIR", "qik-hair" },
                    { 723547, 1727259004.0788493, false, 0.0, "Wangao", "wangao" },
                    { 723623, 1727259004.0690162, false, 0.0, "JAMANO", "jamano" },
                    { 724507, 1727259004.0642569, false, 0.0, "HƯƠNG TÂM", "huong-tam" },
                    { 725099, 1727259004.0619149, false, 0.0, "Teeworld", "teeworld" },
                    { 725785, 1727259004.065475, false, 0.0, "TTV STORE", "ttv-store" },
                    { 726687, 1727259004.0639219, false, 0.0, "The Cocoon Original Vietnam", "the-cocoon-original-vietnam" },
                    { 733743, 1727259004.0705144, false, 0.0, "Dr.D", "dr-d" },
                    { 734939, 1727259004.0641756, false, 0.0, "ADINO", "adino" },
                    { 736383, 1727259004.0627544, false, 0.0, "Euro Viet Perfumery Millenia", "euro-viet-perfumery-millenia" },
                    { 737237, 1727259004.0668569, false, 0.0, "HT SYS", "ht-sys" },
                    { 737737, 1727259004.0619781, false, 0.0, "Julido Store", "julido-store" },
                    { 737925, 1727259004.0816946, false, 0.0, "ongtre", "ongtre" },
                    { 738541, 1727259004.078366, false, 0.0, "Lover's Hair Salon", "lover-s-hair-salon" },
                    { 738697, 1727259004.0644963, false, 0.0, "Wincofood", "wincofood" },
                    { 740219, 1727259004.0617163, false, 0.0, "Jinrinteen", "jinrinteen" },
                    { 740617, 1727259004.0698795, false, 0.0, "LMCATION", "lmcation" },
                    { 741217, 1727259004.0677748, false, 0.0, "Power Men", "power-men" },
                    { 743295, 1727259004.0672374, false, 0.0, "Mason Natural", "mason-natural" },
                    { 745233, 1727259004.0822399, false, 0.0, "RongDali Toys", "rongdali-toys" },
                    { 745705, 1727259004.0727248, false, 0.0, "Food King", "food-king" },
                    { 776333, 1727259004.0661335, false, 0.0, "Hải Sản Hoàng Gia", "hai-san-hoang-gia" },
                    { 776837, 1727259004.0625272, false, 0.0, "MVP", "mvp" },
                    { 792977, 1727259004.0622077, false, 0.0, "Lalala baby", "lalala-baby" },
                    { 793807, 1727259004.0613899, false, 0.0, "TERRISA", "terrisa" },
                    { 798353, 1727259004.0840361, false, 0.0, "Moony Natural", "moony-natural" },
                    { 805571, 1727259004.0776751, false, 0.0, "FAU", "fau" },
                    { 807217, 1727259004.0673497, false, 0.0, "Danny Green", "danny-green" },
                    { 807231, 1727259004.0683761, false, 0.0, "2ph", "2ph" },
                    { 808721, 1727259004.0635693, false, 0.0, "Ozzy Fresh", "ozzy-fresh" },
                    { 832811, 1727259004.0683007, false, 0.0, "BIOAMICUS", "bioamicus" },
                    { 834293, 1727259004.0683792, false, 0.0, "Zespri", "zespri" },
                    { 834619, 1727259004.0647051, false, 0.0, "Korean Pear", "korean-pear" },
                    { 836787, 1727259004.0781765, false, 0.0, "Dalat Milk", "dalat-milk" },
                    { 838721, 1727259004.0789971, false, 0.0, "Thiên An", "thien-an2" },
                    { 839549, 1727259004.0624547, false, 0.0, "EB", "eb" },
                    { 839837, 1727259004.0653541, false, 0.0, "FuNu", "funu" },
                    { 841411, 1727259004.0772011, false, 0.0, "GEXlife ", "gexlife" },
                    { 841593, 1727259004.0665033, false, 0.0, "VIJULLY", "vijully" },
                    { 841971, 1727259004.0620406, false, 0.0, "SZone", "szone" },
                    { 846687, 1727259004.0613835, false, 0.0, "PAK", "pak" },
                    { 847713, 1727259004.0609112, false, 0.0, "BioCheck", "biocheck" },
                    { 847905, 1727259004.0771303, false, 0.0, "DIBLANC", "diblanc" },
                    { 852971, 1727259004.0752573, false, 0.0, "RIZIN", "rizin" },
                    { 853295, 1727259004.0696585, false, 0.0, "HDPHARMA", "hdpharma" },
                    { 853799, 1727259004.0696285, false, 0.0, "inFace", "inface" },
                    { 854447, 1727259004.0662415, false, 0.0, "Bottega Zelachi", "bottega-zelachi" },
                    { 854451, 1727259004.0662351, false, 0.0, "Paysan Breton", "paysan-breton" },
                    { 857807, 1727259004.0735111, false, 0.0, "CADA", "cada" },
                    { 858145, 1727259004.0759308, false, 0.0, "Tinh Dầu 100", "tinh-dau-100" },
                    { 859997, 1727259004.0841572, false, 0.0, "Stanhome Family Expert", "stanhome-family-expert" },
                    { 860369, 1727259004.0732167, false, 0.0, "DLX", "dlx" },
                    { 860507, 1727259004.0612266, false, 0.0, "Yakult", "yakult" },
                    { 862531, 1727259004.0735047, false, 0.0, "Faztbaby", "faztbaby" },
                    { 862545, 1727259004.0834987, false, 0.0, "Vemoda", "vemoda" },
                    { 862907, 1727259004.0654881, false, 0.0, "KACHOO", "kachoo" },
                    { 864251, 1727259004.0686555, false, 0.0, "ORHE", "orhe" },
                    { 864561, 1727259004.0672803, false, 0.0, "HBH", "hbh" },
                    { 870157, 1727259004.0615318, false, 0.0, "Jordan&Judy", "jordan-judy" },
                    { 872003, 1727259004.0638616, false, 0.0, "Huyền Phi", "huyen-phi" },
                    { 872851, 1727259004.080482, false, 0.0, "HQJeans", "hqjeans" },
                    { 873101, 1727259004.0650561, false, 0.0, "Candle Cup", "candle-cup" },
                    { 873385, 1727259004.0648184, false, 0.0, "Ebony", "ebony" },
                    { 874293, 1727259004.069406, false, 0.0, "Carrara", "carrara" },
                    { 878331, 1727259004.0665853, false, 0.0, "Sâm nhung bổ thận", "sam-nhung-bo-than" },
                    { 879253, 1727259004.0749321, false, 0.0, "Úc", "uc" },
                    { 880149, 1727259004.07884, false, 0.0, "Bách Mộc", "bach-moc" },
                    { 884245, 1727259004.0854659, false, 0.0, "MEKOPHAR", "mekophar" },
                    { 885693, 1727259004.0837481, false, 0.0, "ROSAVAN", "rosavan" },
                    { 886169, 1727259004.07376, false, 0.0, "Lebenlang", "lebenlang" },
                    { 886923, 1727259004.0652621, false, 0.0, "FAMAPRO", "famapro" },
                    { 890533, 1727259004.0727532, false, 0.0, "Otafuku", "otafuku" },
                    { 890647, 1727259004.0624583, false, 0.0, "PFP", "pfp" },
                    { 892671, 1727259004.0810819, false, 0.0, "Dr Glatt", "dr-glatt" },
                    { 892751, 1727259004.0618563, false, 0.0, "TAKIHA", "takiha" },
                    { 911799, 1727259004.0717368, false, 0.0, "MaxBiocare Australia", "maxbiocare-australia" },
                    { 924793, 1727259004.0626812, false, 0.0, "Ohh Granola ", "ohh-granola" },
                    { 925095, 1727259004.0634875, false, 0.0, "Go Green", "go-green" },
                    { 926913, 1727259004.0652256, false, 0.0, "Oriss", "oriss" },
                    { 928393, 1727259004.0727661, false, 0.0, "THÀNH VIỆT", "thanh-viet" },
                    { 929841, 1727259004.0628436, false, 0.0, "BOORUI", "boorui" },
                    { 930161, 1727259004.07302, false, 0.0, "ATUNER", "atuner" },
                    { 930615, 1727259004.080373, false, 0.0, "ESTOMAGEL", "estomagel" },
                    { 934373, 1727259004.066144, false, 0.0, "Tài Thịnh Phát", "tai-thinh-phat" },
                    { 938671, 1727259004.0704911, false, 0.0, "Dr.Lavic", "dr-lavic" },
                    { 939041, 1727259004.0835178, false, 0.0, "LACDY COSMETICS", "lacdy-cosmetics" },
                    { 1105493, 1727259004.064472, false, 0.0, "LOLIFOOD", "lolifood" },
                    { 1219171, 1727259004.0789559, false, 0.0, "DANA ORLA COSMETIC", "dana-orla-cosmetic" },
                    { 1936511, 1727259004.0796766, false, 0.0, "ZSZ", "zsz" },
                    { 3000371, 1727259004.0647228, false, 0.0, "GoGreen", "gogreen" },
                    { 3008403, 1727259004.0736992, false, 0.0, "Bilaha", "bilaha" },
                    { 3574065, 1727259004.0844979, false, 0.0, "Redikick", "redikick" },
                    { 3748887, 1727259004.0822368, false, 0.0, "Shouse", "shouse" },
                    { 3794985, 1727259004.0811515, false, 0.0, "MỸ PHONG", "my-phong" },
                    { 3795841, 1727259004.0845916, false, 0.0, "Dmax fashion", "dmax-fashion" },
                    { 3799115, 1727259004.0655472, false, 0.0, "OLV ", "olv" },
                    { 3799173, 1727259004.0611887, false, 0.0, "HAINAMFOODS", "hainamfoods" },
                    { 3799587, 1727259004.0707524, false, 0.0, "DECEMBERY", "decembery" },
                    { 3812995, 1727259004.0744529, false, 0.0, "TOP BLK", "top-blk" },
                    { 3831231, 1727259004.0680714, false, 0.0, "sen đạt phương", "sen-dat-phuong" },
                    { 3835637, 1727259004.0679843, false, 0.0, "G.E.M", "g-e-m" },
                    { 3866781, 1727259004.0633056, false, 0.0, "Nhà của Mẹ", "nha-cua-me" },
                    { 3867703, 1727259004.0628064, false, 0.0, "BREATH PEARLS", "breath-pearls" },
                    { 3955813, 1727259004.0627685, false, 0.0, "Ema", "ema" },
                    { 3974293, 1727259004.079658, false, 0.0, "Zenyum", "zenyum" },
                    { 3978001, 1727259004.0624781, false, 0.0, "Finefood", "finefood" },
                    { 3979027, 1727259004.0633516, false, 0.0, "Vankyo", "vankyo" },
                    { 3981367, 1727259004.0613737, false, 0.0, "Hifarm", "hifarm" },
                    { 3985581, 1727259004.06283, false, 0.0, "CTFAST", "ctfast" },
                    { 3989771, 1727259004.0676725, false, 0.0, "TABAHA", "tabaha" },
                    { 4003377, 1727259004.0835593, false, 0.0, "RITANA", "ritana" },
                    { 4004887, 1727259004.0678637, false, 0.0, "Emspo", "emspo" },
                    { 4005953, 1727259004.0722592, false, 0.0, "Tifalu", "tifalu" },
                    { 4022955, 1727259004.060945, false, 0.0, "PHAMATECH", "phamatech" },
                    { 4022977, 1727259004.0733783, false, 0.0, "Babycoccole", "babycoccole" },
                    { 4048625, 1727259004.0617261, false, 0.0, "NIU24", "niu24" },
                    { 4188097, 1727259004.0702853, false, 0.0, "Thaimex Seafood", "thaimex-seafood" },
                    { 4202843, 1727259004.0608771, false, 0.0, "Sóc Nhí", "soc-nhi" },
                    { 4204847, 1727259004.0677257, false, 0.0, "Yangjiang", "yangjiang" },
                    { 4213813, 1727259004.0835276, false, 0.0, "Gennie", "gennie" },
                    { 4224691, 1727259004.0639477, false, 0.0, "VinBuy", "vinbuy" },
                    { 4228801, 1727259004.0681627, false, 0.0, "KidAndMom", "kidandmom" },
                    { 4234729, 1727259004.0666528, false, 0.0, "Damas", "damas" },
                    { 4235751, 1727259004.0741577, false, 0.0, "Anpaso", "anpaso" },
                    { 4237711, 1727259004.0611601, false, 0.0, "TOPMEAL", "topmeal" },
                    { 4238147, 1727259004.0704775, false, 0.0, "CELLKEY-SCIEN", "cellkey-scien" },
                    { 4243635, 1727259004.0788336, false, 0.0, "MEGATOYS", "megatoys" },
                    { 4244853, 1727259004.06165, false, 0.0, "Tamayoko", "tamayoko" },
                    { 4245195, 1727259004.0751553, false, 0.0, "Herorange", "herorange" },
                    { 4245251, 1727259004.0729201, false, 0.0, "Ritex", "ritex" },
                    { 4246951, 1727259004.0615587, false, 0.0, "TIDAMO Tinh Dầu Số 1", "tidamo-tinh-dau-so-1" },
                    { 4247083, 1727259004.0804391, false, 0.0, "KOSMEN", "kosmen" },
                    { 4249975, 1727259004.066572, false, 0.0, "Fujikima", "fujikima" },
                    { 4250493, 1727259004.0701995, false, 0.0, "pehouse", "pehouse" },
                    { 4256997, 1727259004.0846903, false, 0.0, "CRESTA", "cresta" },
                    { 4258443, 1727259004.0720873, false, 0.0, "O'beauty", "o-beauty" },
                    { 4259871, 1727259004.0789757, false, 0.0, "VietTin Mart", "viettin-mart" },
                    { 4267275, 1727259004.068028, false, 0.0, "ZAVAS", "zavas" },
                    { 4267617, 1727259004.083534, false, 0.0, "NanoTime Beauty", "nanotime-beauty" },
                    { 4269901, 1727259004.0632989, false, 0.0, "MO hi", "mo-hi" },
                    { 4271555, 1727259004.0615685, false, 0.0, "DEGO PHARMA", "dego-pharma" },
                    { 4275489, 1727259004.0778043, false, 0.0, "Khang Thận Đơn", "khang-than-don" },
                    { 4276361, 1727259004.0777752, false, 0.0, "Quablue", "quablue" },
                    { 4283907, 1727259004.0717225, false, 0.0, "HMD Pharma", "hmd-pharma" },
                    { 4285259, 1727259004.0692952, false, 0.0, "HangZhou Jiangge Toys", "hangzhou-jiangge-toys" },
                    { 4288551, 1727259004.0757575, false, 0.0, "Dr.maya", "dr-maya" },
                    { 4294017, 1727259004.067414, false, 0.0, "Tojy", "tojy" },
                    { 4307205, 1727259004.0737729, false, 0.0, "Besti", "besti" },
                    { 4401601, 1727259004.065964, false, 0.0, "KAVY", "kavy" },
                    { 4406879, 1727259004.0836389, false, 0.0, "ICOTTON", "icotton" },
                    { 4408565, 1727259004.0744298, false, 0.0, "SOHOGO", "sohogo" },
                    { 4416483, 1727259004.0611532, false, 0.0, "Meat Master", "meat-master" },
                    { 4423495, 1727259004.0612431, false, 0.0, "HAPPI OHA", "happi-oha" },
                    { 4424515, 1727259004.0677905, false, 0.0, "MIHOCO", "mihoco" },
                    { 4427231, 1727259004.0783949, false, 0.0, "Foam Cleaner", "foam-cleaner" },
                    { 4428301, 1727259004.0628502, false, 0.0, "ThoiTrangXinh", "thoitrangxinh" },
                    { 4428771, 1727259004.0735235, false, 0.0, "Hier", "hier" },
                    { 4431443, 1727259004.0696714, false, 0.0, "CALCIUM MILK", "calcium-milk" },
                    { 4435235, 1727259004.083406, false, 0.0, "Dr. Spock", "dr-spock" },
                    { 4435237, 1727259004.0649052, false, 0.0, "NAGATANIEN", "nagatanien" },
                    { 4436761, 1727259004.0726852, false, 0.0, "Thaimex", "thaimex" },
                    { 4439829, 1727259004.0781956, false, 0.0, "Lumiar", "lumiar" },
                    { 4440139, 1727259004.0810785, false, 0.0, "HKMED", "hkmed" },
                    { 4440205, 1727259004.0721004, false, 0.0, "SOTERIA", "soteria" },
                    { 4440483, 1727259004.0686164, false, 0.0, "Time Secret", "time-secret" },
                    { 4440587, 1727259004.0630116, false, 0.0, "VHL", "vhl" },
                    { 4469177, 1727259004.0619812, false, 0.0, "Chandi", "chandi" },
                    { 4481399, 1727259004.0783503, false, 0.0, "Heebee Vietnam", "heebee-vietnam" },
                    { 4488819, 1727259004.0852897, false, 0.0, "GAMES", "games" },
                    { 4509313, 1727259004.0659008, false, 0.0, "Sora", "sora" },
                    { 4509765, 1727259004.0725827, false, 0.0, "ORACARE", "oracare" },
                    { 4510553, 1727259004.0700531, false, 0.0, "Brave Person", "brave-person" },
                    { 4510557, 1727259004.0837543, false, 0.0, "AIN Closet", "ain-closet" },
                    { 4511355, 1727259004.0804493, false, 0.0, "SCITECH", "scitech" },
                    { 4524605, 1727259004.0804095, false, 0.0, "WaterPush", "waterpush" },
                    { 4525341, 1727259004.070364, false, 0.0, "GRANAROLO", "granarolo" },
                    { 4534193, 1727259004.0696349, false, 0.0, "THAFA", "thafa" },
                    { 4534305, 1727259004.0744076, false, 0.0, "Alika", "alika" },
                    { 4539407, 1727259004.0804176, false, 0.0, "TiMa.lala", "tima-lala" },
                    { 4540893, 1727259004.0724251, false, 0.0, "rock underwear", "rock-underwear" },
                    { 4581269, 1727259004.0618191, false, 0.0, "Baw", "baw" },
                    { 4581507, 1727259004.0683827, false, 0.0, "Bio Ngon", "bio-ngon" },
                    { 4598395, 1727259004.0614583, false, 0.0, "Ah Huat White Coffee", "ah-huat-white-coffee" },
                    { 4630457, 1727259004.0720286, false, 0.0, "Mude", "mude" },
                    { 4642827, 1727259004.0802307, false, 0.0, "Orsa Food", "orsa-food" },
                    { 4655747, 1727259004.0832713, false, 0.0, "Cetaphil Baby", "cetaphil-baby" },
                    { 4678387, 1727259004.0676465, false, 0.0, "Cỏ mềm HomeLab", "co-mem-homelab" },
                    { 4681523, 1727259004.0793376, false, 0.0, "IDLOCA", "idloca" },
                    { 4698843, 1727259004.0782881, false, 0.0, "TOKIMORI", "tokimori" },
                    { 4708201, 1727259004.0699227, false, 0.0, "SAM CLO 1", "sam-clo-1" },
                    { 4712245, 1727259004.0775008, false, 0.0, "Venado", "venado" },
                    { 4712403, 1727259004.0857396, false, 0.0, "OVERCO", "overco" },
                    { 4712983, 1727259004.0777783, false, 0.0, "Versaces", "versaces" },
                    { 4732457, 1727259004.0789659, false, 0.0, "Bergami", "bergami" },
                    { 4738243, 1727259004.0709653, false, 0.0, "unmei", "unmei" },
                    { 4741611, 1727259004.0612128, false, 0.0, "Angst Trường Vinh", "angst-truong-vinh" },
                    { 4765359, 1727259004.0673692, false, 0.0, "Fs Fruit", "fs-fruit" },
                    { 4765385, 1727259004.0611429, false, 0.0, "FS Trái Cây Tươi", "fs-trai-cay-tuoi" },
                    { 4765577, 1727259004.0856576, false, 0.0, "AgiCham", "agicham" },
                    { 4766125, 1727259004.0744624, false, 0.0, "ROSTEX PHARMA", "rostex-pharma" },
                    { 4766405, 1727259004.0728197, false, 0.0, "OZO", "ozo" },
                    { 4773221, 1727259004.0778165, false, 0.0, "DOKBUAKU", "dokbuaku" },
                    { 4776729, 1727259004.0610521, false, 0.0, "Pocketbook", "pocketbook" },
                    { 4777447, 1727259004.0791378, false, 0.0, "PEACE HOUSE BY LE THAI BINH", "peace-house-by-le-thai-binh" },
                    { 4784973, 1727259004.0639184, false, 0.0, "sin hair", "sin-hair" },
                    { 4807177, 1727259004.0619383, false, 0.0, "Micado", "micado" },
                    { 4820811, 1727259004.0608976, false, 0.0, "PEAFLO", "peaflo" },
                    { 4827915, 1727259004.0696812, false, 0.0, "powergra", "powergra" },
                    { 4828741, 1727259004.0661128, false, 0.0, "Lộc Tài Food", "loc-tai-food" },
                    { 4835051, 1727259004.0785112, false, 0.0, "Hiền Trần BOUTIQUE", "hien-tran-boutique" },
                    { 4842649, 1727259004.0689974, false, 0.0, "FACIO", "facio" },
                    { 4851111, 1727259004.0783291, false, 0.0, "Hitsamitsu", "hitsamitsu" },
                    { 4877037, 1727259004.0796363, false, 0.0, "HNT NATURAL PRODUCT", "hnt-natural-product" },
                    { 4877879, 1727259004.07427, false, 0.0, "ANNASEAfresh", "annaseafresh" },
                    { 4884071, 1727259004.0717299, false, 0.0, "an mộc hương", "an-moc-huong" },
                    { 4884089, 1727259004.0615821, false, 0.0, "BaoAn", "baoan" },
                    { 4886121, 1727259004.0613637, false, 0.0, "GAS Á CHÂU", "gas-a-chau" },
                    { 4888849, 1727259004.0720024, false, 0.0, "ĐẤT PHÚ", "dat-phu" },
                    { 4898665, 1727259004.0783534, false, 0.0, "The Moshav Farm", "the-moshav-farm" },
                    { 4907867, 1727259004.0775037, false, 0.0, "Caliven Keni", "caliven-keni" },
                    { 4916839, 1727259004.0836165, false, 0.0, "YarnArt", "yarnart" },
                    { 4952659, 1727259004.0614061, false, 0.0, "Ông Bầu", "ong-bau" },
                    { 4955375, 1727259004.0794048, false, 0.0, "Nabizam", "nabizam" },
                    { 4956901, 1727259004.0725925, false, 0.0, "Moyuum", "moyuum" },
                    { 4957929, 1727259004.0612197, false, 0.0, "Maestrella", "maestrella" },
                    { 4958627, 1727259004.0627787, false, 0.0, "DORON", "doron" },
                    { 4964815, 1727259004.0650961, false, 0.0, "Minh House", "minh-house" },
                    { 4966851, 1727259004.0675304, false, 0.0, "Marzipan", "marzipan" },
                    { 4988569, 1727259004.0652685, false, 0.0, "Genky", "genky" },
                    { 4989679, 1727259004.0787697, false, 0.0, "Aikuu Bear", "aikuu-bear" },
                    { 5003355, 1727259004.0620339, false, 0.0, "US ARMY", "us-army" },
                    { 5003535, 1727259004.0822852, false, 0.0, "MKPHARMA", "mkpharma" },
                    { 5012119, 1727259004.0825737, false, 0.0, "GILLEE", "gillee" },
                    { 5013437, 1727259004.0636251, false, 0.0, "Casademont", "casademont" },
                    { 5018565, 1727259004.0653844, false, 0.0, "Đầm váy Mina", "dam-vay-mina" },
                    { 5018831, 1727259004.0847764, false, 0.0, "Dapper Dan", "dapper-dan" },
                    { 5018963, 1727259004.0647297, false, 0.0, "BIGSEAFOOD", "bigseafood" },
                    { 5023305, 1727259004.0701456, false, 0.0, "greenmilk", "greenmilk" },
                    { 5025027, 1727259004.0674763, false, 0.0, "Fine Food Jsc", "fine-food-jsc" },
                    { 5026491, 1727259004.0802341, false, 0.0, "Oniiz", "oniiz" },
                    { 5033337, 1727259004.0608904, false, 0.0, "PaKaSa", "pakasa" },
                    { 5036755, 1727259004.0745192, false, 0.0, "THÀNH HÂN 3HT", "thanh-han-3ht" },
                    { 5036903, 1727259004.0657494, false, 0.0, "ONEZ", "onez" },
                    { 5040313, 1727259004.0609386, false, 0.0, "Humasis", "humasis" },
                    { 5043271, 1727259004.0666695, false, 0.0, "NBAYOU", "nbayou" },
                    { 5046069, 1727259004.0641329, false, 0.0, "Obongoo", "obongoo" },
                    { 5046775, 1727259004.0801396, false, 0.0, "Maguzt", "maguzt" },
                    { 5047129, 1727259004.0677814, false, 0.0, "Fairywill", "fairywill" },
                    { 5058721, 1727259004.0809419, false, 0.0, "New BeGinning", "new-beginning" },
                    { 5074117, 1727259004.0842447, false, 0.0, "GDV", "gdv" },
                    { 5084265, 1727259004.0685077, false, 0.0, "SEAGIFOOD", "seagifood" },
                    { 5085907, 1727259004.066123, false, 0.0, "BULA kitchen", "bula-kitchen" },
                    { 5095183, 1727259004.0696616, false, 0.0, "Kim Hoàng Ân", "kim-hoang-an" },
                    { 5095619, 1727259004.0699911, false, 0.0, "NEEDS OF WISDOM", "needs-of-wisdom" },
                    { 5097039, 1727259004.0658619, false, 0.0, "Miwako", "miwako" },
                    { 5098843, 1727259004.0833149, false, 0.0, "YOMIT", "yomit" },
                    { 5099183, 1727259004.072859, false, 0.0, "KingOil", "kingoil" },
                    { 5104653, 1727259004.0609417, false, 0.0, "Pharmacity", "pharmacity" },
                    { 5109603, 1727259004.084229, false, 0.0, "Dolphi", "dolphi" },
                    { 5124791, 1727259004.0692987, false, 0.0, "EOC", "eoc" },
                    { 5132069, 1727259004.0639875, false, 0.0, "MINIIN", "miniin" },
                    { 5143951, 1727259004.0672612, false, 0.0, "Värna", "v-rna" },
                    { 5152551, 1727259004.0753336, false, 0.0, "TINECO", "tineco" },
                    { 5156931, 1727259004.0645344, false, 0.0, "Topbright", "topbright" },
                    { 5160827, 1727259004.0617616, false, 0.0, "HAHANCO", "hahanco" },
                    { 5166107, 1727259004.0626781, false, 0.0, "Mitsui", "mitsui" },
                    { 5166975, 1727259004.0645516, false, 0.0, "Anh Lam Store", "anh-lam-store" },
                    { 5167307, 1727259004.0728495, false, 0.0, "HUNMUI", "hunmui" },
                    { 5173051, 1727259004.0662284, false, 0.0, "Luminus", "luminus" },
                    { 5173455, 1727259004.0638478, false, 0.0, "MIANZ GROUP", "mianz-group" },
                    { 5178283, 1727259004.0623589, false, 0.0, "KTEL", "ktel" },
                    { 5178681, 1727259004.0698862, false, 0.0, "Bikini Passport CLOTHES X BIKINI", "bikini-passport-clothes-x-bikini" },
                    { 5179953, 1727259004.0705895, false, 0.0, "OTiV", "otiv" },
                    { 5180595, 1727259004.0765865, false, 0.0, "PASIORI TM", "pasiori-tm" },
                    { 5180899, 1727259004.0817854, false, 0.0, "nOor", "noor" },
                    { 5180961, 1727259004.0686855, false, 0.0, "Angela Gold", "angela-gold" },
                    { 5181029, 1727259004.0665886, false, 0.0, "Alipas", "alipas" },
                    { 5181975, 1727259004.0674655, false, 0.0, "Lutosa", "lutosa" },
                    { 5182155, 1727259004.0658424, false, 0.0, "Molfix", "molfix" },
                    { 5191837, 1727259004.0666595, false, 0.0, "Mitomo", "mitomo" },
                    { 5195449, 1727259004.0796332, false, 0.0, "SHB", "shb" },
                    { 5195453, 1727259004.0796237, false, 0.0, "SHB PRO MASK", "shb-pro-mask" },
                    { 5196303, 1727259004.0709069, false, 0.0, "HT Sports", "ht-sports" },
                    { 5200629, 1727259004.0770071, false, 0.0, "hona Life", "hona-life" },
                    { 5202469, 1727259004.0720906, false, 0.0, "HANVIET", "hanviet" },
                    { 5207801, 1727259004.0823493, false, 0.0, "PH PUHA", "ph-puha" },
                    { 5209239, 1727259004.0718925, false, 0.0, "Armacura", "armacura" },
                    { 5211067, 1727259004.0612526, false, 0.0, "Ottima Cheese", "ottima-cheese" },
                    { 5211389, 1727259004.0816462, false, 0.0, "BASICARE", "basicare" },
                    { 5211409, 1727259004.067719, false, 0.0, "MAXMATE", "maxmate" },
                    { 5211449, 1727259004.0816369, false, 0.0, "EVERMATE", "evermate" },
                    { 5211657, 1727259004.0794978, false, 0.0, "Stanbroke", "stanbroke" },
                    { 5212315, 1727259004.0747712, false, 0.0, "BABOYKA", "baboyka" },
                    { 5217519, 1727259004.0822659, false, 0.0, "El avion", "el-avion" },
                    { 5217537, 1727259004.0790651, false, 0.0, "Lock & Lock", "lock-&-lock" },
                    { 5219673, 1727259004.0842161, false, 0.0, "Khớp Khang Thọ", "khop-khang-tho" },
                    { 5221825, 1727259004.0686655, false, 0.0, "Life360", "life360" },
                    { 5222401, 1727259004.0705481, false, 0.0, "Kagawa", "kagawa" },
                    { 5224013, 1727259004.0829082, false, 0.0, "NTnailbox", "ntnailbox" },
                    { 5224641, 1727259004.0726185, false, 0.0, "HENRYSA", "henrysa" },
                    { 5225483, 1727259004.0753033, false, 0.0, "TakyHome", "takyhome" },
                    { 5225873, 1727259004.0622008, false, 0.0, "TILO KIDS", "tilo-kids" },
                    { 5227303, 1727259004.0833678, false, 0.0, "taky home", "taky-home" },
                    { 5227647, 1727259004.0809233, false, 0.0, "biolizin", "biolizin" },
                    { 5227657, 1727259004.0692484, false, 0.0, "Ferrolip", "ferrolip" },
                    { 5228261, 1727259004.0784452, false, 0.0, "Sunree", "sunree" },
                    { 5234459, 1727259004.0635796, false, 0.0, "Đen Đỏ", "den-do" },
                    { 5235671, 1727259004.0686431, false, 0.0, "Pink Addiet", "pink-addiet" },
                    { 5242323, 1727259004.0737376, false, 0.0, "albus", "albus" },
                    { 5244009, 1727259004.0720489, false, 0.0, "Tami Natural", "tami-natural" },
                    { 5244477, 1727259004.0627887, false, 0.0, "Slimming Care Việt Nam", "slimming-care-viet-nam" },
                    { 5246949, 1727259004.0835528, false, 0.0, "VISPO", "vispo" },
                    { 5249391, 1727259004.0835979, false, 0.0, "BFO", "bfo" },
                    { 5258881, 1727259004.0704136, false, 0.0, "Loving", "loving" },
                    { 5258943, 1727259004.0699584, false, 0.0, "Việt Pháp Collection", "viet-phap-collection" },
                    { 5259865, 1727259004.0777817, false, 0.0, "Kềm Nhật", "kem-nhat" },
                    { 5259909, 1727259004.0648117, false, 0.0, "HAGOKA", "hagoka" },
                    { 5265175, 1727259004.0752969, false, 0.0, "Muaisi", "muaisi" },
                    { 5267939, 1727259004.078872, false, 0.0, "Mr.T Beef", "mr-t-beef" },
                    { 5268289, 1727259004.0672543, false, 0.0, "Hi Mom Hapi", "hi-mom-hapi" },
                    { 5272071, 1727259004.0622146, false, 0.0, "dododios", "dododios" },
                    { 5275107, 1727259004.0703254, false, 0.0, "Kyokuyo", "kyokuyo" },
                    { 5305193, 1727259004.0648749, false, 0.0, "Dr. Oetker", "dr-oetker" },
                    { 5309795, 1727259004.0652485, false, 0.0, "SKY MASK", "sky-mask" },
                    { 5310901, 1727259004.0842638, false, 0.0, "sohi", "sohi" },
                    { 5312311, 1727259004.0726993, false, 0.0, "Union Trading", "union-trading" },
                    { 5332317, 1727259004.0835309, false, 0.0, "Dr.Sun", "dr-sun" },
                    { 5333835, 1727259004.0726657, false, 0.0, "Thơm Tiền Giang", "thom-tien-giang" },
                    { 5334715, 1727259004.0834417, false, 0.0, "Flawsome", "flawsome" },
                    { 5337041, 1727259004.0661061, false, 0.0, "TT Mart Fruit", "tt-mart-fruit" },
                    { 5337417, 1727259004.065944, false, 0.0, "Pillow Care", "pillow-care" },
                    { 5337837, 1727259004.0790455, false, 0.0, "Dia Purple", "dia-purple" },
                    { 5347121, 1727259004.0683382, false, 0.0, "EASYKIDS", "easykids" },
                    { 5351035, 1727259004.0738096, false, 0.0, "FTAKY", "ftaky" },
                    { 5354313, 1727259004.0776877, false, 0.0, "CHỢ NGON", "cho-ngon" },
                    { 5365729, 1727259004.0840263, false, 0.0, "Kitin Natural", "kitin-natural" },
                    { 5367201, 1727259004.0629039, false, 0.0, "NHUH20", "nhuh20" },
                    { 5375543, 1727259004.0847704, false, 0.0, "OLEXRS", "olexrs" },
                    { 5378043, 1727259004.0791094, false, 0.0, "Air Pot", "air-pot" },
                    { 5380019, 1727259004.0816851, false, 0.0, "Lá House", "la-house" },
                    { 5380365, 1727259004.080127, false, 0.0, "Agusha", "agusha" },
                    { 5381089, 1727259004.0647471, false, 0.0, "Mekong PEARL", "mekong-pearl" },
                    { 5386443, 1727259004.0661404, false, 0.0, "HẢI ĐẢO FOOD", "hai-dao-food" },
                    { 5396813, 1727259004.0674927, false, 0.0, "Bodegas Verdugez", "bodegas-verdugez" },
                    { 5402475, 1727259004.0646248, false, 0.0, "Nexta", "nexta" },
                    { 5402543, 1727259004.0669715, false, 0.0, "SOMIANTON", "somianton" },
                    { 5402879, 1727259004.0661161, false, 0.0, "Tony Fruit", "tony-fruit" },
                    { 5406107, 1727259004.0691495, false, 0.0, "lilahome", "lilahome" },
                    { 5413627, 1727259004.0625792, false, 0.0, "SEAVY", "seavy" },
                    { 5465099, 1727259004.0616035, false, 0.0, "Roichen", "roichen" },
                    { 5505533, 1727259004.0832019, false, 0.0, "AFRO", "afro" },
                    { 5506393, 1727259004.0694027, false, 0.0, "HORMEL SPAM", "hormel-spam" },
                    { 5534927, 1727259004.065053, false, 0.0, "Feelex", "feelex" },
                    { 5624299, 1727259004.0631733, false, 0.0, "Gro-Fa", "gro-fa" },
                    { 5647115, 1727259004.0815165, false, 0.0, "Mamogom", "mamogom" },
                    { 5647959, 1727259004.0633092, false, 0.0, "MySun", "mysun" },
                    { 5656957, 1727259004.0625961, false, 0.0, "VT-Gas", "vt-gas" },
                    { 5658771, 1727259004.0649524, false, 0.0, "Gia Đình Gas", "gia-dinh-gas" },
                    { 5659829, 1727259004.0636988, false, 0.0, "thủ đức gas", "thu-duc-gas" },
                    { 5660705, 1727259004.0625992, false, 0.0, "Gas Gia Đình", "gas-gia-dinh" },
                    { 5677653, 1727259004.0689116, false, 0.0, "Vilady", "vilady" },
                    { 5678587, 1727259004.0782216, false, 0.0, "Fobaby", "fobaby" },
                    { 5696237, 1727259004.0792451, false, 0.0, "DIRTY COINS", "dirty-coins" },
                    { 5706641, 1727259004.0621843, false, 0.0, "NAVIVU", "navivu" },
                    { 5707797, 1727259004.0697384, false, 0.0, "FMALL", "fmall" },
                    { 5714829, 1727259004.0609319, false, 0.0, "HGSG Pharma", "hgsg-pharma" },
                    { 5715999, 1727259004.0727439, false, 0.0, "Millac", "millac" },
                    { 5716001, 1727259004.0727823, false, 0.0, "Delifrance", "delifrance" },
                    { 5716005, 1727259004.0703287, false, 0.0, "Bonta Viva", "bonta-viva" },
                    { 5717579, 1727259004.0745161, false, 0.0, "Samono", "samono" },
                    { 5722581, 1727259004.0707595, false, 0.0, "Yu Cherry", "yu-cherry" },
                    { 5728387, 1727259004.0802276, false, 0.0, "The Alaska Prime", "the-alaska-prime" },
                    { 5744435, 1727259004.0788045, false, 0.0, "Valens", "valens" },
                    { 5745605, 1727259004.0689216, false, 0.0, "DRU", "dru" },
                    { 5778039, 1727259004.0741706, false, 0.0, "Akodo", "akodo" },
                    { 6244549, 1727259004.0624645, false, 0.0, "Tâm Lợi Foods", "tam-loi-foods" },
                    { 6275103, 1727259004.0782185, false, 0.0, "Chuchu Baby", "chuchu-baby" },
                    { 6688165, 1727259004.0822079, false, 0.0, "Herbland", "herbland" },
                    { 6993527, 1727259004.0679908, false, 0.0, "LAAS", "laas" },
                    { 7243965, 1727259004.0853903, false, 0.0, "The Cafuné", "the-cafune" },
                    { 7244965, 1727259004.0828924, false, 0.0, "Vietket", "vietket" },
                    { 7247911, 1727259004.0632524, false, 0.0, "Hapi Vietnam", "hapi-vietnam" },
                    { 7270469, 1727259004.0650859, false, 0.0, "M.O.I - Make Over Image", "m-o-i-make-over-image" },
                    { 7276487, 1727259004.078372, false, 0.0, "Sin Hair Sản Phẩm Chăm Sóc Tóc Cao Cấp", "sin-hair-san-pham-cham-soc-toc-cao-cap" },
                    { 7278655, 1727259004.0649493, false, 0.0, "TGas", "tgas" },
                    { 7281287, 1727259004.0612888, false, 0.0, "Nikka", "nikka" },
                    { 7281291, 1727259004.061311, false, 0.0, "Homare", "homare" },
                    { 7281295, 1727259004.0636587, false, 0.0, "Satsuma Shuzo", "satsuma-shuzo" },
                    { 7281303, 1727259004.0735824, false, 0.0, "APAN", "apan" },
                    { 7281335, 1727259004.0719061, false, 0.0, "Marusan", "marusan" },
                    { 7281339, 1727259004.0663123, false, 0.0, "Kirishima", "kirishima" },
                    { 7281345, 1727259004.0636623, false, 0.0, "Hakkaisan", "hakkaisan" },
                    { 7281347, 1727259004.0612693, false, 0.0, "Hakutsuru", "hakutsuru" },
                    { 7281349, 1727259004.0636418, false, 0.0, "Homare Kokko", "homare-kokko" },
                    { 7281351, 1727259004.0625663, false, 0.0, "Iichiko", "iichiko" },
                    { 7281355, 1727259004.0649152, false, 0.0, "Hakutake", "hakutake" },
                    { 7281357, 1727259004.0625694, false, 0.0, "Japanch Yaky", "japanch-yaky" },
                    { 7281369, 1727259004.0636384, false, 0.0, "Daijingo", "daijingo" },
                    { 7281373, 1727259004.0663223, false, 0.0, "Mugi kojika", "mugi-kojika" },
                    { 7281375, 1727259004.063669, false, 0.0, "KIRISHIMA BRILLIANT", "kirishima-brilliant" },
                    { 7281377, 1727259004.0636451, false, 0.0, "Suishin", "suishin" },
                    { 7281379, 1727259004.0649188, false, 0.0, "Iwai", "iwai" },
                    { 7281381, 1727259004.0685177, false, 0.0, "Honjozo", "honjozo" },
                    { 7281401, 1727259004.0841184, false, 0.0, "Shigeno", "shigeno" },
                    { 7282123, 1727259004.0811167, false, 0.0, "Usmile", "usmile" },
                    { 7283143, 1727259004.0650897, false, 0.0, "HENRYSA Bạn của mọi nhà", "henrysa-ban-cua-moi-nha" },
                    { 7288833, 1727259004.0743635, false, 0.0, "DORON the best service", "doron-the-best-service" },
                    { 7290005, 1727259004.0674691, false, 0.0, "Sannadle-Maru", "sannadle-maru" },
                    { 7293039, 1727259004.0652025, false, 0.0, "LES FRENCHISES", "les-frenchises" },
                    { 7294005, 1727259004.0683992, false, 0.0, "HAI NAM CO .,LTD AGRICULTURAL AND SEAFOOD PRODUCT COMPANY", "hai-nam-co-ltd-agricultural-and-seafood-product-company" },
                    { 7303429, 1727259004.0685349, false, 0.0, "Kobuta Manju", "kobuta-manju" },
                    { 7304183, 1727259004.0737665, false, 0.0, "TEEMENT", "teement" },
                    { 7306583, 1727259004.0847416, false, 0.0, "Mychi", "mychi" },
                    { 7307977, 1727259004.0683415, false, 0.0, "ZooZoo", "zoozoo" },
                    { 7309383, 1727259004.0636885, false, 0.0, "AKAIBOUSHI", "akaiboushi" },
                    { 7309395, 1727259004.0662785, false, 0.0, "BELL SHOKUHINE", "bell-shokuhine" },
                    { 7309403, 1727259004.0614257, false, 0.0, "EARTH HMP", "earth-hmp" },
                    { 7309405, 1727259004.063576, false, 0.0, "AKAGI", "akagi" },
                    { 7309409, 1727259004.0635729, false, 0.0, "BETSUKAI", "betsukai" },
                    { 7309415, 1727259004.0788753, false, 0.0, "DAIEI FOODS", "daiei-foods" },
                    { 7309423, 1727259004.0727787, false, 0.0, "FUJIKKO", "fujikko" },
                    { 7309431, 1727259004.0636351, false, 0.0, "GEKKEIKAN", "gekkeikan" },
                    { 7309439, 1727259004.0661948, false, 0.0, "INABA SYOKUHIN", "inaba-syokuhin" },
                    { 7309441, 1727259004.0782783, false, 0.0, "INOUE SHOTEN", "inoue-shoten" },
                    { 7309443, 1727259004.0638046, false, 0.0, "ITOU SEIKA", "itou-seika" },
                    { 7324269, 1727259004.0639713, false, 0.0, "Vinaphar", "vinaphar" },
                    { 7337473, 1727259004.0789461, false, 0.0, "QUYÊN LARA Natural product Spa Health club", "quyen-lara-natural-product-spa-health-club" },
                    { 7339545, 1727259004.0773487, false, 0.0, "MENE period panties A REVOLUTION FOR WOMEN", "mene-period-panties-a-revolution-for-women" },
                    { 7355373, 1727259004.0651295, false, 0.0, "LASHE SUPERFOOD", "lashe-superfood" },
                    { 7357047, 1727259004.0613277, false, 0.0, "BA ĐẢO DURIAN", "ba-dao-durian" },
                    { 7358189, 1727259004.0642116, false, 0.0, "Garco 10", "garco-10" },
                    { 7358195, 1727259004.0695596, false, 0.0, "HIDATI", "hidati" },
                    { 7363505, 1727259004.0816112, false, 0.0, "MITU FRESH", "mitu-fresh" },
                    { 7367537, 1727259004.0636954, false, 0.0, "thuducgas", "thuducgas" },
                    { 7368269, 1727259004.0744398, false, 0.0, "TOK DO DO TOKDODO TOK DO DO", "tok-do-do-tokdodo-tok-do-do" },
                    { 7368299, 1727259004.0820456, false, 0.0, "2NDDATE", "2nddate" },
                    { 7378235, 1727259004.0615551, false, 0.0, "Kingdom Herb", "kingdom-herb" },
                    { 7380233, 1727259004.0648916, false, 0.0, "NG NGO GIA JUST IN TIME JOYAL SAUCE", "ng-ngo-gia-just-in-time-joyal-sauce" },
                    { 7380859, 1727259004.0656345, false, 0.0, "Anlimen Gentle Cuff Shirt", "anlimen-gentle-cuff-shirt" },
                    { 7400077, 1727259004.0633123, false, 0.0, "BK TOTECH", "bk-totech" },
                    { 7406091, 1727259004.0717187, false, 0.0, "CHAMI FOOD", "chami-food" },
                    { 7406365, 1727259004.0613704, false, 0.0, "Yến Sào Bảo Sơn", "yen-sao-bao-son" },
                    { 7412627, 1727259004.0661917, false, 0.0, "Kim And You", "kim-and-you" },
                    { 7414643, 1727259004.0625041, false, 0.0, "Conviette", "conviette" },
                    { 7457291, 1727259004.0648279, false, 0.0, "Dan.DPak", "dan-dpak" },
                    { 7481997, 1727259004.0823941, false, 0.0, "ALIZE YARNS", "alize-yarns" },
                    { 7491535, 1727259004.0694935, false, 0.0, "La Mere Poulard", "la-mere-poulard" },
                    { 7491883, 1727259004.0719323, false, 0.0, "Wasa", "wasa" },
                    { 7520663, 1727259004.0782914, false, 0.0, "PrettySkin", "prettyskin" },
                    { 7798515, 1727259004.0616627, false, 0.0, "INFACE SONIC", "inface-sonic" },
                    { 7812699, 1727259004.0622113, false, 0.0, "QY TOYS", "qy-toys" },
                    { 7817261, 1727259004.0612726, false, 0.0, "Hải Sản Trung Nam ", "hai-san-trung-nam" },
                    { 7818543, 1727259004.0743115, false, 0.0, "Lecon Seafoods", "lecon-seafoods" },
                    { 7821583, 1727259004.0751967, false, 0.0, "Olexrs+HairSalon", "olexrs+hairsalon" },
                    { 7826699, 1727259004.0633409, false, 0.0, "TEKKIN", "tekkin" },
                    { 7840377, 1727259004.0683861, false, 0.0, "Sun sweet", "sun-sweet" },
                    { 7842899, 1727259004.077615, false, 0.0, "Avisure Kids", "avisure-kids" },
                    { 7864221, 1727259004.0784199, false, 0.0, "Multi Vitamin Plus", "multi-vitamin-plus" },
                    { 7878711, 1727259004.0821853, false, 0.0, "Ngũ Cốc Long Giang", "ngu-coc-long-giang" },
                    { 7879249, 1727259004.0744205, false, 0.0, "FINO", "fino" },
                    { 7880761, 1727259004.0622373, false, 0.0, "Liworldco", "liworldco" },
                    { 7896671, 1727259004.0650826, false, 0.0, "Loren Professional", "loren-professional" },
                    { 7896693, 1727259004.082886, false, 0.0, "Enmys", "enmys" },
                    { 7899451, 1727259004.0708303, false, 0.0, "MMLG", "mmlg" },
                    { 7899465, 1727259004.0613143, false, 0.0, "PAPAFOOD", "papafood" },
                    { 7900359, 1727259004.074935, false, 0.0, "ENFA A+", "enfa-a+" },
                    { 7903429, 1727259004.0617032, false, 0.0, "P Pinkaha", "p-pinkaha" },
                    { 7905793, 1727259004.0744777, false, 0.0, "Sâm Kỳ Vương", "sam-ky-vuong" },
                    { 7917161, 1727259004.0803685, false, 0.0, "Pharmatech", "pharmatech" },
                    { 7917221, 1727259004.0777559, false, 0.0, "DEAR BODY", "dear-body" },
                    { 7918509, 1727259004.0727024, false, 0.0, "Vuonnhafood", "vuonnhafood" },
                    { 7918573, 1727259004.0660992, false, 0.0, "Daily Fruits ", "daily-fruits" },
                    { 7926521, 1727259004.0827477, false, 0.0, "NANO BAMBOO", "nano-bamboo" },
                    { 7958291, 1727259004.0693407, false, 0.0, "Daily fruit", "daily-fruit" },
                    { 7980869, 1727259004.0725636, false, 0.0, "BUBI BABY CARRIERS", "bubi-baby-carriers" },
                    { 8046673, 1727259004.0701692, false, 0.0, "mediphar", "mediphar" },
                    { 8047575, 1727259004.0751042, false, 0.0, "COLLAGEN X3 ĐA WHITENING BODY CREAM", "collagen-x3-da-whitening-body-cream" },
                    { 8059993, 1727259004.0704842, false, 0.0, "TWO-O COLOR", "two-o-color" },
                    { 8062079, 1727259004.0659673, false, 0.0, "MINH CHÂU PUZZLE", "minh-chau-puzzle" },
                    { 8062221, 1727259004.0678272, false, 0.0, "JETZT", "jetzt" },
                    { 8081391, 1727259004.0782981, false, 0.0, "Habaria", "habaria" },
                    { 8081583, 1727259004.0757706, false, 0.0, "HEBES", "hebes" },
                    { 8091701, 1727259004.0676365, false, 0.0, "KEILEI", "keilei" },
                    { 8117077, 1727259004.0772412, false, 0.0, "Joou", "joou" },
                    { 8120873, 1727259004.0836291, false, 0.0, "Hare", "hare" },
                    { 8126075, 1727259004.0721519, false, 0.0, "Lock&Lock", "lock-lock" },
                    { 8130707, 1727259004.0720348, false, 0.0, "Pretty makeup Hanru", "pretty-makeup-hanru" },
                    { 8137481, 1727259004.0615852, false, 0.0, "RIBI", "ribi" },
                    { 8168527, 1727259004.0739107, false, 0.0, "Isla Bonita", "isla-bonita" },
                    { 8173499, 1727259004.0660372, false, 0.0, "XELEX", "xelex" },
                    { 8173763, 1727259004.0708072, false, 0.0, "TYM", "tym" },
                    { 8175123, 1727259004.0795891, false, 0.0, "NEUTRADERM", "neutraderm" },
                    { 8178777, 1727259004.0794179, false, 0.0, "EcoWipes Việt Nam", "ecowipes-viet-nam" },
                    { 8181541, 1727259004.0790069, false, 0.0, "SOTHING Xiangwu", "sothing-xiangwu" },
                    { 8185209, 1727259004.0835211, false, 0.0, "Kat&Kev", "kat-kev" },
                    { 8189173, 1727259004.0678174, false, 0.0, "CWELL", "cwell" },
                    { 8191055, 1727259004.0759716, false, 0.0, "biocarepharma", "biocarepharma" },
                    { 8194775, 1727259004.0621552, false, 0.0, "Akamama", "akamama" },
                    { 8198669, 1727259004.0627131, false, 0.0, "Glamrr Q", "glamrr-q" },
                    { 8199089, 1727259004.0771573, false, 0.0, "Seedcoms", "seedcoms" },
                    { 8202658, 1727259004.0743082, false, 0.0, "L'grow", "l-grow" },
                    { 8202712, 1727259004.061276, false, 0.0, "BODEGAS VERDUGUEZ", "bodegas-verduguez" },
                    { 8204070, 1727259004.0846872, false, 0.0, "Nuan Nuan", "nuan-nuan" },
                    { 8204610, 1727259004.0815489, false, 0.0, "Lusol", "lusol" },
                    { 8205594, 1727259004.0681951, false, 0.0, "ASSTAR", "asstar" },
                    { 8207848, 1727259004.0632887, false, 0.0, "BH Kids", "bh-kids" },
                    { 8210142, 1727259004.0621355, false, 0.0, "Nestle S-26", "nestle-s-26" },
                    { 8212352, 1727259004.0725987, false, 0.0, "Bafaby", "bafaby" },
                    { 8212461, 1727259004.0639508, false, 0.0, "fofaHome", "fofahome" },
                    { 8213764, 1727259004.0765991, false, 0.0, "ALYUP", "alyup" },
                    { 8213988, 1727259004.0693731, false, 0.0, "PLANTIN", "plantin" },
                    { 8214366, 1727259004.0827889, false, 0.0, "V Sport Like", "v-sport-like" },
                    { 8215026, 1727259004.0625305, false, 0.0, "Trentham Estate", "trentham-estate" },
                    { 8216940, 1727259004.0767827, false, 0.0, "NGADO", "ngado" },
                    { 8217148, 1727259004.0625138, false, 0.0, "Le FOURNIL De PIERRE", "le-fournil-de-pierre" },
                    { 8218395, 1727259004.0625241, false, 0.0, "Nước Mắm Ngọc Huy", "nuoc-mam-ngoc-huy" },
                    { 8220858, 1727259004.0674305, false, 0.0, "ĐẬU MÊ TA", "dau-me-ta" },
                    { 8222284, 1727259004.0852337, false, 0.0, "miracle baby", "miracle-baby" },
                    { 8222406, 1727259004.068222, false, 0.0, "Confidence", "confidence" },
                    { 8222587, 1727259004.0665689, false, 0.0, "Gubix", "gubix" },
                    { 8222890, 1727259004.0721388, false, 0.0, "Agal", "agal" },
                    { 8225973, 1727259004.0729103, false, 0.0, "Siro Húng Chanh Family", "siro-hu-ng-chanh-family" },
                    { 8227425, 1727259004.0823524, false, 0.0, "Nhàu Noni Hương Thanh", "nha-u-noni-huong-thanh" },
                    { 8227745, 1727259004.061552, false, 0.0, "Purefeel", "purefeel" },
                    { 8228657, 1727259004.0833964, false, 0.0, "POKEMON TOYS", "pokemon-toys" },
                    { 8229425, 1727259004.0731721, false, 0.0, "Motive", "motive" },
                    { 8230451, 1727259004.0777359, false, 0.0, "Glint By Vdivov", "glint-by-vdivov" },
                    { 8232231, 1727259004.0662119, false, 0.0, "Smilla Food", "smilla-food" },
                    { 8232252, 1727259004.0648415, false, 0.0, "Latteria Sorrentina", "latteria-sorrentina" },
                    { 8232372, 1727259004.0694799, false, 0.0, "La Vieja Fábrica", "la-vieja-fabrica" },
                    { 8232474, 1727259004.074858, false, 0.0, "Nubie", "nubie" },
                    { 8232840, 1727259004.0705409, false, 0.0, "MY SOUL", "my-soul" },
                    { 8240097, 1727259004.0631795, false, 0.0, "ratoff-ars", "ratoff-ars" },
                    { 8240480, 1727259004.0632305, false, 0.0, "matilia", "matilia" },
                    { 8241022, 1727259004.0760405, false, 0.0, "Xtoy", "xtoy" },
                    { 8241226, 1727259004.0783851, false, 0.0, "smatayoko", "smatayoko" },
                    { 8241507, 1727259004.067626, false, 0.0, "HAJI OFFICIAL", "haji-official" },
                    { 8242534, 1727259004.0744169, false, 0.0, "Roug Men's Grooming", "roug-men-s-grooming" },
                    { 8245106, 1727259004.0833361, false, 0.0, "Omega Vit", "omega-vit" },
                    { 8245236, 1727259004.0775957, false, 0.0, "Huro Probiotics", "huro-probiotics" },
                    { 8245251, 1727259004.0776179, false, 0.0, "M'Smarty", "m-smarty" },
                    { 8245521, 1727259004.0817139, false, 0.0, "Korhinoor", "korhinoor" },
                    { 8246361, 1727259004.0757232, false, 0.0, "Manna Morinaga", "manna-morinaga" },
                    { 8247976, 1727259004.0608635, false, 0.0, "Tinh Dầu Nhiên", "tinh-dau-nhien" },
                    { 8248965, 1727259004.0616069, false, 0.0, "LuckyJQR", "luckyjqr" },
                    { 8249145, 1727259004.0613964, false, 0.0, "aidebao", "aidebao" },
                    { 8250912, 1727259004.0765123, false, 0.0, "Cát Tường Savoury", "cat-tuong-savoury" },
                    { 8251022, 1727259004.0757544, false, 0.0, "Befoma", "befoma" },
                    { 8252318, 1727259004.0660467, false, 0.0, "JoyStar", "joystar" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Created", "IsDeleted", "LastModified", "Name", "ParentId", "ThumbnailUrl" },
                values: new object[,]
                {
                    { 2, 1727259004.0865436, false, 0.0, "Root", null, "https://salt.tikicdn.com/cache/280x280/ts/product/97/bc/ae/7fe8a253cce6da248aebe6679bb9c88f.jpg" },
                    { 8895, 1727259004.0877764, false, 0.0, "NESLE FITNESSES", null, "" },
                    { 8977, 1727259004.0877807, false, 0.0, "Ưu đãi Từ Tiki và Microsoft", null, "" },
                    { 9983, 1727259004.087785, false, 0.0, "hazeline lauching", null, "" },
                    { 11033, 1727259004.0877893, false, 0.0, "Engineering", null, "" },
                    { 915, 1727259004.0868821, false, 0.0, "Thời trang nam", 2, "https://salt.tikicdn.com/ts/category/00/5d/97/384ca1a678c4ee93a0886a204f47645d.png" },
                    { 931, 1727259004.0868039, false, 0.0, "Thời trang nữ", 2, "https://salt.tikicdn.com/ts/category/55/5b/80/48cbaafe144c25d5065786ecace86d38.png" },
                    { 976, 1727259004.0869951, false, 0.0, "Túi thời trang nữ", 2, "https://salt.tikicdn.com/ts/category/31/a7/94/6524d2ecbec216816d91b6066452e3f2.png" },
                    { 1520, 1727259004.0867319, false, 0.0, "Làm Đẹp - Sức Khỏe", 2, "https://salt.tikicdn.com/ts/category/73/0e/89/bf5095601d17f9971d7a08a1ffe98a42.png" },
                    { 1686, 1727259004.0870259, false, 0.0, "Giày - Dép nam", 2, "https://salt.tikicdn.com/ts/category/d6/7f/6c/5d53b60efb9448b6a1609c825c29fa40.png" },
                    { 1703, 1727259004.0869484, false, 0.0, "Giày - Dép nữ", 2, "https://salt.tikicdn.com/ts/category/cf/ed/e1/5a6b58f21fbcad0d201480c987f8defe.png" },
                    { 1789, 1727259004.0866098, false, 0.0, "Điện Thoại - Máy Tính Bảng", 2, "https://salt.tikicdn.com/ts/category/54/c0/ff/fe98a4afa2d3e5142dc8096addc4e40b.png" },
                    { 1801, 1727259004.0876489, false, 0.0, "Máy Ảnh - Máy Quay Phim", 2, "https://salt.tikicdn.com/ts/category/2d/7c/45/e4976f3fa4061ab310c11d2a1b759e5b.png" },
                    { 1815, 1727259004.0873797, false, 0.0, "Thiết Bị Số - Phụ Kiện Số", 2, "https://salt.tikicdn.com/ts/category/75/34/29/78e428fdd90408587181005f5cc3de32.png" },
                    { 1846, 1727259004.087158, false, 0.0, "Laptop - Máy Vi Tính - Linh kiện", 2, "https://salt.tikicdn.com/ts/category/92/b5/c0/3ffdb7dbfafd5f8330783e1df20747f6.png" },
                    { 1882, 1727259004.0867903, false, 0.0, "Điện Gia Dụng", 2, "https://salt.tikicdn.com/ts/category/61/d4/ea/e6ea3ffc1fcde3b6224d2bb691ea16a2.png" },
                    { 1883, 1727259004.0871892, false, 0.0, "Nhà Cửa - Đời Sống", 2, "https://salt.tikicdn.com/ts/category/f6/22/46/7e2185d2cf1bca72d5aeac385a865b2b.png" },
                    { 1975, 1727259004.0875812, false, 0.0, "Thể Thao - Dã Ngoại", 2, "https://salt.tikicdn.com/ts/category/0b/5e/3d/00941c9eb338ea62a47d5b1e042843d8.png" },
                    { 2549, 1727259004.086556, false, 0.0, "Đồ Chơi - Mẹ & Bé", 2, "https://salt.tikicdn.com/ts/category/13/64/43/226301adcc7660ffcf44a61bb6df99b7.png" },
                    { 4221, 1727259004.0875285, false, 0.0, "Điện Tử - Điện Lạnh", 2, "https://salt.tikicdn.com/ts/category/c8/82/d4/64c561c4ced585c74b9c292208e4995a.png" },
                    { 4384, 1727259004.0873239, false, 0.0, "Bách Hóa Online", 2, "https://salt.tikicdn.com/ts/category/40/0f/9b/62a58fd19f540c70fce804e2a9bb5b2d.png" },
                    { 6000, 1727259004.0870841, false, 0.0, "Balo và Vali", 2, "https://salt.tikicdn.com/ts/category/3e/c0/30/1110651bd36a3e0d9b962cf135c818ee.png" },
                    { 8322, 1727259004.0875061, false, 0.0, "Nhà Sách Tiki", 2, "https://salt.tikicdn.com/ts/category/ed/20/60/afa9b3b474bf7ad70f10dd6443211d5f.png" },
                    { 8371, 1727259004.0871289, false, 0.0, "Đồng hồ và Trang sức", 2, "https://salt.tikicdn.com/ts/category/8b/d4/a8/5924758b5c36f3b1c43b6843f52d6dd2.png" },
                    { 8594, 1727259004.0874746, false, 0.0, "Ô Tô - Xe Máy - Xe Đạp", 2, "https://salt.tikicdn.com/ts/category/69/f5/36/c6cd9e2849854630ed74ff1678db8f19.png" },
                    { 11312, 1727259004.0874109, false, 0.0, "Voucher - Dịch vụ", 2, "https://salt.tikicdn.com/ts/category/0a/c9/7b/8e466bdf6d4a5f5e14665ce56e58631d.png" },
                    { 11603, 1727259004.0877109, false, 0.0, "Thời Trang Cho Mẹ Và Bé", 2, "https://salt.tikicdn.com/assets/img/image.svg" },
                    { 15078, 1727259004.0877423, false, 0.0, "Chăm sóc nhà cửa", 2, "https://salt.tikicdn.com/assets/img/image.svg" },
                    { 17166, 1727259004.0872467, false, 0.0, "Cross Border - Hàng Quốc Tế", 2, "https://salt.tikicdn.com/ts/category/3c/e4/99/eeee1801c838468d94af9997ec2bbe42.png" },
                    { 27498, 1727259004.087111, false, 0.0, "Phụ kiện thời trang", 2, "https://salt.tikicdn.com/ts/category/ca/53/64/49c6189a0e1c1bf7cb91b01ff6d3fe43.png" },
                    { 27616, 1727259004.0870612, false, 0.0, "Túi thời trang nam", 2, "https://salt.tikicdn.com/ts/category/9b/31/af/669e6a133118e5439d6c175e27c1f963.png" },
                    { 44792, 1727259004.086638, false, 0.0, "NGON", 2, "https://salt.tikicdn.com/ts/category/1e/8c/08/d8b02f8a0d958c74539316e8cd437cbd.png" },
                    { 54042, 1727259004.0877016, false, 0.0, "Sản phẩm Tài chính - Bảo hiểm", 2, "https://salt.tikicdn.com/ts/category/a0/49/f4/a75f6e5dc021b0005fb8923b9846abc2.jpg" },
                    { 316, 1727259004.0875151, false, 0.0, "Sách tiếng Việt", 8322, "" },
                    { 320, 1727259004.0875108, false, 0.0, "English Books", 8322, "" },
                    { 917, 1727259004.0868869, false, 0.0, "Áo thun nam", 915, "" },
                    { 918, 1727259004.0868912, false, 0.0, "Áo sơ mi nam", 915, "" },
                    { 925, 1727259004.0868957, false, 0.0, "Áo vest - Áo khoác nam", 915, "" },
                    { 933, 1727259004.0868733, false, 0.0, "Áo thun nữ", 931, "" },
                    { 934, 1727259004.0868599, false, 0.0, "Áo sơ mi nữ", 931, "" },
                    { 935, 1727259004.0868645, false, 0.0, "Áo kiểu nữ", 931, "" },
                    { 936, 1727259004.0868239, false, 0.0, "Áo vest - Áo khoác nữ", 931, "" },
                    { 941, 1727259004.0868087, false, 0.0, "Đầm nữ", 931, "" },
                    { 958, 1727259004.0870705, false, 0.0, "Túi đeo chéo nam", 27616, "" },
                    { 959, 1727259004.0870793, false, 0.0, "Ví nam", 27616, "" },
                    { 975, 1727259004.0871201, false, 0.0, "Phụ kiện thời trang nữ", 27498, "" },
                    { 977, 1727259004.0871403, false, 0.0, "Đồng hồ nữ", 8371, "" },
                    { 981, 1727259004.0869775, false, 0.0, "Giày boots nữ", 1703, "" },
                    { 984, 1727259004.0869818, false, 0.0, "Dép - Guốc nữ", 1703, "" },
                    { 1008, 1727259004.086973, false, 0.0, "Giày Đế xuồng nữ ", 1703, "" },
                    { 1192, 1727259004.0869687, false, 0.0, "Giày búp bê", 1703, "" },
                    { 1508, 1727259004.0868509, false, 0.0, "Đồ ngủ - Đồ mặc nhà nữ", 931, "" },
                    { 1581, 1727259004.0870397, false, 0.0, "Giày tây nam", 1686, "" },
                    { 1582, 1727259004.0867369, false, 0.0, "Chăm sóc da mặt", 1520, "" },
                    { 1584, 1727259004.0867412, false, 0.0, "Trang điểm ", 1520, "" },
                    { 1591, 1727259004.0867591, false, 0.0, "Chăm sóc tóc và da đầu", 1520, "" },
                    { 1592, 1727259004.08675, false, 0.0, "Chăm sóc cơ thể", 1520, "" },
                    { 1594, 1727259004.0867455, false, 0.0, "Chăm sóc cá nhân", 1520, "" },
                    { 1595, 1727259004.0867636, false, 0.0, "Nước hoa", 1520, "" },
                    { 1625, 1727259004.086786, false, 0.0, "Chăm sóc răng miệng", 1520, "" },
                    { 1702, 1727259004.0868282, false, 0.0, "Áo liền quần - Bộ trang phục", 931, "" },
                    { 1778, 1727259004.0871358, false, 0.0, "Đồng hồ nam", 8371, "" },
                    { 1794, 1727259004.0866191, false, 0.0, "Máy tính bảng", 1789, "" },
                    { 1795, 1727259004.0866148, false, 0.0, "Điện thoại Smartphone", 1789, "" },
                    { 1796, 1727259004.0866289, false, 0.0, "Điện thoại phổ thông", 1789, "" },
                    { 1818, 1727259004.0876582, false, 0.0, "Phụ Kiện Máy Ảnh, Máy Quay", 1801, "" },
                    { 1840, 1727259004.0876629, false, 0.0, "Balo - Túi Đựng - Bao Da", 1801, "" },
                    { 1884, 1727259004.0867951, false, 0.0, "Đồ dùng nhà bếp", 1882, "" },
                    { 1946, 1727259004.0867996, false, 0.0, "Thiết bị gia đình", 1882, "" },
                    { 1951, 1727259004.087194, false, 0.0, "Dụng cụ nhà bếp", 1883, "" },
                    { 1954, 1727259004.087198, false, 0.0, "Đồ dùng phòng ăn", 1883, "" },
                    { 1966, 1727259004.087224, false, 0.0, "Đồ dùng và thiết bị nhà tắm", 1883, "" },
                    { 1973, 1727259004.0872111, false, 0.0, "Trang trí nhà cửa", 1883, "" },
                    { 1974, 1727259004.0872283, false, 0.0, "Sửa chữa nhà cửa", 1883, "" },
                    { 2015, 1727259004.0872157, false, 0.0, "Đèn & thiết bị chiếu sáng", 1883, "" },
                    { 2150, 1727259004.0872023, false, 0.0, "Nội thất", 1883, "" },
                    { 2223, 1727259004.0872197, false, 0.0, "Ngoài trời & sân vườn", 1883, "" },
                    { 2306, 1727259004.0867679, false, 0.0, "Dụng cụ làm đẹp", 1520, "" },
                    { 2307, 1727259004.0867724, false, 0.0, "Máy Massage & Thiết bị chăm sóc sức khỏe", 1520, "" },
                    { 2322, 1727259004.086777, false, 0.0, "Thực phẩm chức năng", 1520, "" },
                    { 2328, 1727259004.087564, false, 0.0, "Tủ lạnh", 4221, "" },
                    { 2551, 1727259004.0865617, false, 0.0, "Tã, Bỉm", 2549, "" },
                    { 2640, 1727259004.0866005, false, 0.0, "Chăm sóc mẹ mang thai, sau sinh", 2549, "" },
                    { 2663, 1727259004.0871763, false, 0.0, "Thiết Bị Mạng", 1846, "" },
                    { 2667, 1727259004.087389, false, 0.0, "Thiết Bị Chơi Game và Phụ Kiện", 1815, "" },
                    { 2757, 1727259004.0876718, false, 0.0, "Ống Kính (Lens)", 1801, "" },
                    { 3862, 1727259004.0875375, false, 0.0, "Máy giặt", 4221, "" },
                    { 3863, 1727259004.0875463, false, 0.0, "Máy sấy quần áo", 4221, "" },
                    { 3864, 1727259004.0875506, false, 0.0, "Máy rửa chén", 4221, "" },
                    { 3865, 1727259004.0875552, false, 0.0, "Máy lạnh - Máy điều hòa", 4221, "" },
                    { 3866, 1727259004.0875597, false, 0.0, "Máy nước nóng", 4221, "" },
                    { 3868, 1727259004.0875683, false, 0.0, "Tủ đông - Tủ mát", 4221, "" },
                    { 3869, 1727259004.0875728, false, 0.0, "Tủ ướp rượu", 4221, "" },
                    { 4077, 1727259004.087688, false, 0.0, "Camera Giám Sát", 1801, "" },
                    { 4227, 1727259004.0875919, false, 0.0, "Các môn thể thao đồng đội", 1975, "" },
                    { 4386, 1727259004.0877471, false, 0.0, "Vệ sinh nhà cửa", 15078, "" },
                    { 4387, 1727259004.0877645, false, 0.0, "Giặt giũ & Chăm sóc quần áo", 15078, "" },
                    { 4388, 1727259004.08776, false, 0.0, "Giấy vệ sinh và giấy ăn", 15078, "" },
                    { 4399, 1727259004.0877516, false, 0.0, "Vệ sinh nhà bếp", 15078, "" },
                    { 4400, 1727259004.0877559, false, 0.0, "Vệ sinh nhà tắm", 15078, "" },
                    { 4421, 1727259004.0873284, false, 0.0, "Đồ Ăn Vặt", 4384, "" },
                    { 4422, 1727259004.0873449, false, 0.0, "Gia Vị và Chế Biến", 4384, "" },
                    { 4441, 1727259004.0877719, false, 0.0, "Diệt côn trùng", 15078, "" },
                    { 4546, 1727259004.0869043, false, 0.0, "Áo nỉ - Áo len nam", 915, "" },
                    { 4550, 1727259004.086962, false, 0.0, "Giày sandals nữ", 1703, "" },
                    { 4551, 1727259004.0869863, false, 0.0, "Giày lười nữ", 1703, "" },
                    { 4553, 1727259004.0868328, false, 0.0, "Đồ đôi - Đồ gia đình", 931, "" },
                    { 4554, 1727259004.0868464, false, 0.0, "Đồ lót nữ", 931, "" },
                    { 4558, 1727259004.0870042, false, 0.0, "Túi đeo chéo, túi đeo vai nữ", 976, "" },
                    { 4559, 1727259004.0869999, false, 0.0, "Túi tote nữ", 976, "" },
                    { 4560, 1727259004.0870087, false, 0.0, "Túi xách tay nữ", 976, "" },
                    { 4561, 1727259004.0870132, false, 0.0, "Ví nữ", 976, "" },
                    { 5015, 1727259004.0875332, false, 0.0, "Tivi", 4221, "" },
                    { 5164, 1727259004.086596, false, 0.0, "Đồ dùng cho người già", 2549, "" },
                    { 5188, 1727259004.0877199, false, 0.0, "Thời trang sơ sinh", 11603, "" },
                    { 5189, 1727259004.0877244, false, 0.0, "Thời trang bé gái", 11603, "" },
                    { 5190, 1727259004.0877287, false, 0.0, "Thời trang bé trai", 11603, "" },
                    { 5191, 1727259004.0877156, false, 0.0, "Thời trang bầu", 11603, "" },
                    { 5192, 1727259004.0877335, false, 0.0, "Phụ kiện cho bé", 11603, "" },
                    { 5250, 1727259004.0865912, false, 0.0, "Đồ chơi", 2549, "" },
                    { 5337, 1727259004.0870659, false, 0.0, "Túi xách công sở nam", 27616, "" },
                    { 5340, 1727259004.0870352, false, 0.0, "Giày lười nam", 1686, "" },
                    { 5341, 1727259004.087044, false, 0.0, "Giày sandals nam", 1686, "" },
                    { 5342, 1727259004.0870481, false, 0.0, "Dép nam", 1686, "" },
                    { 5404, 1727259004.0868151, false, 0.0, "Chân váy", 931, "" },
                    { 5451, 1727259004.0873492, false, 0.0, "Chăm sóc thú cưng", 4384, "" },
                    { 5602, 1727259004.087738, false, 0.0, "Phụ kiện thời trang sơ sinh", 11603, "" },
                    { 5873, 1727259004.0867543, false, 0.0, "Sản phẩm thiên nhiên & Khác", 1520, "" },
                    { 6070, 1727259004.0874839, false, 0.0, "Xe điện", 8594, "" },
                    { 6179, 1727259004.0868556, false, 0.0, "Trang phục bơi nữ", 931, "" },
                    { 6526, 1727259004.0871017, false, 0.0, "Vali, phụ kiện vali ", 6000, "" },
                    { 6568, 1727259004.0865719, false, 0.0, "Thực phẩm ăn dặm", 2549, "" },
                    { 6826, 1727259004.0876055, false, 0.0, "Giày thể thao nam", 1975, "" },
                    { 6827, 1727259004.0876098, false, 0.0, "Giày thể thao nữ", 1975, "" },
                    { 7741, 1727259004.0875196, false, 0.0, "Văn phòng phẩm", 8322, "" },
                    { 8039, 1727259004.0873935, false, 0.0, "Thiết Bị Đeo Thông Minh và Phụ Kiện", 1815, "" },
                    { 8047, 1727259004.0876925, false, 0.0, "Máy Bay Camera và Phụ Kiện", 1801, "" },
                    { 8060, 1727259004.0871718, false, 0.0, "Thiết Bị Lưu Trữ", 1846, "" },
                    { 8061, 1727259004.0866332, false, 0.0, "Điện thoại bàn", 1789, "" },
                    { 8074, 1727259004.0875769, false, 0.0, "Phụ kiện điện lạnh", 4221, "" },
                    { 8093, 1727259004.0871809, false, 0.0, "PC - Máy Tính Bộ", 1846, "" },
                    { 8095, 1727259004.0871627, false, 0.0, "Laptop", 1846, "" },
                    { 8129, 1727259004.0871849, false, 0.0, "Linh Kiện Máy Tính - Phụ Kiện Máy Tính", 1846, "" },
                    { 8142, 1727259004.0867815, false, 0.0, "Hỗ trợ tình dục", 1520, "" },
                    { 8214, 1727259004.0874023, false, 0.0, "Phụ Kiện Điện Thoại và Máy Tính Bảng", 1815, "" },
                    { 8215, 1727259004.0873845, false, 0.0, "Thiết Bị Âm Thanh và Phụ Kiện", 1815, "" },
                    { 8313, 1727259004.0872068, false, 0.0, "Đồ dùng phòng ngủ", 1883, "" },
                    { 8337, 1727259004.0870523, false, 0.0, "Giày boots nam", 1686, "" },
                    { 8338, 1727259004.0870569, false, 0.0, "Phụ kiện giày nam", 1686, "" },
                    { 8339, 1727259004.0865669, false, 0.0, "Dinh dưỡng cho bé", 2549, "" },
                    { 8350, 1727259004.0870173, false, 0.0, "Ví đi tiệc", 976, "" },
                    { 8352, 1727259004.0870216, false, 0.0, "Phụ kiện túi", 976, "" },
                    { 8355, 1727259004.0869527, false, 0.0, "Giày cao gót", 1703, "" },
                    { 8357, 1727259004.0869908, false, 0.0, "Phụ kiện giày nữ", 1703, "" },
                    { 8370, 1727259004.0871155, false, 0.0, "Mắt kính", 27498, "" },
                    { 8374, 1727259004.0871537, false, 0.0, "Trang sức", 8371, "" },
                    { 8387, 1727259004.0870972, false, 0.0, "Túi du lịch và phụ kiện", 6000, "" },
                    { 8411, 1727259004.0875859, false, 0.0, "Các môn thể thao chơi vợt", 1975, "" },
                    { 8413, 1727259004.0876184, false, 0.0, "Thể thao dưới nước", 1975, "" },
                    { 8431, 1727259004.0874884, false, 0.0, "Xe đạp", 8594, "" },
                    { 8595, 1727259004.0874927, false, 0.0, "Ô tô", 8594, "" },
                    { 8597, 1727259004.0874794, false, 0.0, "Xe máy", 8594, "" },
                    { 10068, 1727259004.0872328, false, 0.0, "Nhạc cụ", 1883, "" },
                    { 10382, 1727259004.0869, false, 0.0, "Áo hoodie nam", 915, "" },
                    { 10389, 1727259004.0868688, false, 0.0, "Áo crop-top", 931, "" },
                    { 10416, 1727259004.0865767, false, 0.0, "Dinh dưỡng cho mẹ", 2549, "" },
                    { 10418, 1727259004.0865817, false, 0.0, "Dinh dưỡng cho người lớn", 2549, "" },
                    { 10570, 1727259004.0866051, false, 0.0, "Chuẩn bị mang thai", 2549, "" },
                    { 10803, 1727259004.0876224, false, 0.0, "Thực phẩm bổ sung năng lượng", 1975, "" },
                    { 11313, 1727259004.0874159, false, 0.0, "Nhà hàng - Ăn uống", 11312, "" },
                    { 11319, 1727259004.0874224, false, 0.0, "Du lịch - Khách sạn", 11312, "" },
                    { 11322, 1727259004.0874269, false, 0.0, "Spa & Làm đẹp", 11312, "" },
                    { 11326, 1727259004.0874395, false, 0.0, "Nha khoa - Sức khỏe", 11312, "" },
                    { 11327, 1727259004.0874312, false, 0.0, "Sự kiện - Giải trí", 11312, "" },
                    { 11332, 1727259004.0874441, false, 0.0, "Khóa học", 11312, "" },
                    { 11333, 1727259004.0874355, false, 0.0, "Sự kiện - Thể thao", 11312, "" },
                    { 11334, 1727259004.0874486, false, 0.0, "Dịch vụ khác", 11312, "" },
                    { 11347, 1727259004.0873537, false, 0.0, "Bộ quà tặng", 4384, "" },
                    { 11375, 1727259004.0871449, false, 0.0, "Đồng hồ trẻ em", 8371, "" },
                    { 11601, 1727259004.0865865, false, 0.0, "Đồ dùng cho bé", 2549, "" },
                    { 12884, 1727259004.0871673, false, 0.0, "Thiết Bị Văn Phòng - Thiết Bị Ngoại Vi", 1846, "" },
                    { 15074, 1727259004.0873358, false, 0.0, "Thực phẩm Đóng hộp và Khô", 4384, "" },
                    { 16004, 1727259004.0869353, false, 0.0, "Đồ bơi - Đồ đi biển nam", 915, "" },
                    { 17208, 1727259004.0875015, false, 0.0, "Dịch vụ, lắp đặt", 8594, "" },
                    { 18328, 1727259004.0875239, false, 0.0, "Quà lưu niệm", 8322, "" },
                    { 20766, 1727259004.0872536, false, 0.0, "Bách hóa online", 17166, "" },
                    { 20824, 1727259004.0872581, false, 0.0, "Điện gia dụng", 17166, "" },
                    { 20908, 1727259004.0872624, false, 0.0, "Làm Đẹp - Sức Khỏe", 17166, "" },
                    { 21054, 1727259004.0872667, false, 0.0, "Điện Thoại - Máy Tính Bảng", 17166, "" },
                    { 21074, 1727259004.0872712, false, 0.0, "Laptop & Máy Vi Tính", 17166, "" },
                    { 21134, 1727259004.0872755, false, 0.0, "Máy Ảnh - Máy Quay Phim", 17166, "" },
                    { 21166, 1727259004.08728, false, 0.0, "Mẹ & Bé", 17166, "" },
                    { 21268, 1727259004.0872843, false, 0.0, "Nhà Cửa - Đời Sống", 17166, "" },
                    { 21298, 1727259004.0872889, false, 0.0, "Sách, Văn phòng phẩm & Quà lưu niệm", 17166, "" },
                    { 21346, 1727259004.0872931, false, 0.0, "Ô tô, xe máy, xe đạp", 17166, "" },
                    { 21356, 1727259004.0872977, false, 0.0, "Thể thao - Dã ngoại", 17166, "" },
                    { 21382, 1727259004.0873015, false, 0.0, "Thiết Bị Số - Phụ Kiện Số", 17166, "" },
                    { 21442, 1727259004.087306, false, 0.0, "Thời Trang", 17166, "" },
                    { 21496, 1727259004.0873103, false, 0.0, "Tivi & Thiết Bị Nghe Nhìn", 17166, "" },
                    { 22998, 1727259004.087358, false, 0.0, "Đồ uống", 4384, "" },
                    { 23054, 1727259004.0872374, false, 0.0, "Đồ thờ cúng", 1883, "" },
                    { 23120, 1727259004.0875964, false, 0.0, "Các môn thể thao đối kháng ", 1975, "" },
                    { 24002, 1727259004.0876012, false, 0.0, "Các môn thể thao khác", 1975, "" },
                    { 24024, 1727259004.0873401, false, 0.0, "Đồ Uống Không Cồn", 4384, "" },
                    { 24064, 1727259004.0876443, false, 0.0, "Golf", 1975, "" },
                    { 24306, 1727259004.0876141, false, 0.0, "Phụ kiện thể thao", 1975, "" },
                    { 24832, 1727259004.087497, false, 0.0, "Phụ kiện - Chăm sóc xe", 8594, "" },
                    { 25036, 1727259004.0873151, false, 0.0, "Sản phẩm - thiết bị công nghiệp", 17166, "" },
                    { 26568, 1727259004.0875416, false, 0.0, "Âm thanh & Phụ kiện Tivi", 4221, "" },
                    { 27468, 1727259004.0873196, false, 0.0, "Artist Collection", 17166, "" },
                    { 27542, 1727259004.0871491, false, 0.0, "Phụ kiện đồng hồ", 8371, "" },
                    { 27548, 1727259004.0869219, false, 0.0, "Đồ lót nam", 915, "" },
                    { 27550, 1727259004.0871243, false, 0.0, "Phụ kiện thời trang nam", 27498, "" },
                    { 27562, 1727259004.0869088, false, 0.0, "Quần dài nam", 915, "" },
                    { 27570, 1727259004.0869131, false, 0.0, "Đồ ngủ, đồ mặc nhà nam", 915, "" },
                    { 27572, 1727259004.0870309, false, 0.0, "Giày thể thao nam", 1686, "" },
                    { 27600, 1727259004.0868196, false, 0.0, "Quần nữ", 931, "" },
                    { 27604, 1727259004.0869572, false, 0.0, "Giày thể thao nữ", 1703, "" },
                    { 27608, 1727259004.0870883, false, 0.0, "Balo", 6000, "" },
                    { 27612, 1727259004.0870929, false, 0.0, "Balo, cặp, túi chống sốc laptop", 6000, "" },
                    { 28432, 1727259004.0873981, false, 0.0, "Thiết Bị Thông Minh và Linh Kiện Điện Tử", 1815, "" },
                    { 28670, 1727259004.0874069, false, 0.0, "Phụ kiện máy tính và Laptop", 1815, "" },
                    { 28794, 1727259004.0876672, false, 0.0, "Ống Kính - Ống Ngắm", 1801, "" },
                    { 28806, 1727259004.0876536, false, 0.0, "Máy Ảnh", 1801, "" },
                    { 28814, 1727259004.087676, false, 0.0, "Thiết Bị Ánh Sáng", 1801, "" },
                    { 28822, 1727259004.0876803, false, 0.0, "Thiết Bị Quay Phim", 1801, "" },
                    { 28834, 1727259004.087697, false, 0.0, "Camera Hành Trình - Action Camera và Phụ Kiện", 1801, "" },
                    { 28856, 1727259004.0866239, false, 0.0, "Máy đọc sách", 1789, "" },
                    { 33466, 1727259004.0874531, false, 0.0, "TikiNOW", 11312, "" },
                    { 44472, 1727259004.0874574, false, 0.0, "Quyên góp", 11312, "" },
                    { 44824, 1727259004.0866427, false, 0.0, "Trái Cây", 44792, "" },
                    { 46516, 1727259004.0874617, false, 0.0, "TicketBox", 11312, "" },
                    { 49372, 1727259004.0868373, false, 0.0, "Thời trang bầu và sau sinh", 931, "" },
                    { 49384, 1727259004.0868418, false, 0.0, "Thời trang nữ trung niên", 931, "" },
                    { 49516, 1727259004.0869176, false, 0.0, "Đồ đôi - Đồ gia đình nam", 915, "" },
                    { 49524, 1727259004.0869265, false, 0.0, "Quần áo nam kích cỡ lớn", 915, "" },
                    { 49532, 1727259004.0869308, false, 0.0, "Quần áo nam trung niên", 915, "" },
                    { 49650, 1727259004.0870748, false, 0.0, "Túi bao tử, túi đeo bụng", 27616, "" },
                    { 52842, 1727259004.087466, false, 0.0, "Vé xe bus", 11312, "" },
                    { 53050, 1727259004.0872419, false, 0.0, "Dụng cụ & Thiết bị tiện ích", 1883, "" },
                    { 53562, 1727259004.0873623, false, 0.0, "Sữa và các Sản phẩm từ sữa", 4384, "" },
                    { 53582, 1727259004.0873666, false, 0.0, "Rượu, bia và nước lên men", 4384, "" },
                    { 53620, 1727259004.0873711, false, 0.0, "Đậu & Hạt Các Loại", 4384, "" },
                    { 54276, 1727259004.0866475, false, 0.0, "Thịt, Trứng", 44792, "" },
                    { 54290, 1727259004.0866549, false, 0.0, "Cá, thuỷ hải sản", 44792, "" },
                    { 54302, 1727259004.0866597, false, 0.0, "Rau củ quả", 44792, "" },
                    { 54316, 1727259004.0866642, false, 0.0, "Thực phẩm đóng hộp và khô", 44792, "" },
                    { 54330, 1727259004.0866692, false, 0.0, "Sữa và các Sản phẩm từ sữa", 44792, "" },
                    { 54344, 1727259004.086674, false, 0.0, "Đông lạnh, mát", 44792, "" },
                    { 54362, 1727259004.0866785, false, 0.0, "Gia Vị và Chế Biến", 44792, "" },
                    { 54412, 1727259004.0866828, false, 0.0, "Đồ uống có cồn", 44792, "" },
                    { 54430, 1727259004.0867276, false, 0.0, "Thực phẩm chay", 44792, "" },
                    { 54438, 1727259004.0866871, false, 0.0, "Dành cho trẻ em", 44792, "" },
                    { 54452, 1727259004.0866916, false, 0.0, "Bánh kẹo, đồ ăn vặt", 44792, "" },
                    { 54466, 1727259004.0866959, false, 0.0, "Chăm sóc thú cưng", 44792, "" },
                    { 54500, 1727259004.0867007, false, 0.0, "Chăm sóc nhà cửa", 44792, "" },
                    { 54514, 1727259004.0867052, false, 0.0, "Gia dụng, tiện ích", 44792, "" },
                    { 56009, 1727259004.0877068, false, 0.0, "Tài Chính", 54042, "" },
                    { 67230, 1727259004.0868776, false, 0.0, "Quần áo nữ kích cỡ lớn", 931, "" },
                    { 67309, 1727259004.0869396, false, 0.0, "Bộ trang phục nam", 915, "" },
                    { 67329, 1727259004.0869441, false, 0.0, "Quần short nam", 915, "" },
                    { 67485, 1727259004.0876267, false, 0.0, "Đồ dùng dã ngoại & Leo núi", 1975, "" },
                    { 67647, 1727259004.0876317, false, 0.0, "Trang phục thể thao", 1975, "" },
                    { 67703, 1727259004.087636, false, 0.0, "Chạy bộ và đi bộ", 1975, "" },
                    { 68140, 1727259004.0871065, false, 0.0, "Phụ kiện du lịch", 6000, "" },
                    { 68576, 1727259004.0873752, false, 0.0, "Ngũ cốc và mứt", 4384, "" },
                    { 68747, 1727259004.0867097, false, 0.0, "Bộ quà tặng", 44792, "" },
                    { 68840, 1727259004.0867145, false, 0.0, "Làm Đẹp - Sức Khỏe", 44792, "" },
                    { 69032, 1727259004.0867188, false, 0.0, "Đồ uống - Pha chế dạng bột", 44792, "" },
                    { 69118, 1727259004.0867233, false, 0.0, "Đồ Uống Không Cồn", 44792, "" },
                    { 69482, 1727259004.0874703, false, 0.0, "Key điện tử", 11312, "" },
                    { 69498, 1727259004.0876403, false, 0.0, "Gym và Boxing", 1975, "" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 17825);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 17827);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 17839);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 18604);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 18634);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 18802);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 18804);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 18977);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 19018);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 19050);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 19588);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 19589);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 19673);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 19813);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 19912);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 20056);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 20306);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 20439);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 20987);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 21104);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 21253);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 21260);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 21261);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 21265);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 21266);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 21268);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 21269);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 21271);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 21273);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 21274);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 21276);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 21278);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 21279);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 21280);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 21282);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 21285);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 21407);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 21408);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 21584);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 21651);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 21692);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 21867);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 22013);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 22017);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 22095);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 22393);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 22653);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 24843);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 24909);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 25009);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 25048);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 25159);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 25229);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 25401);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 25403);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 25422);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 25533);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 25643);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 25706);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 26124);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 26225);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 26233);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 26283);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 26689);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 26692);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 26702);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 26718);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 26779);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 26782);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 26793);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 26809);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 26848);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 26855);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 26863);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 26878);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 27314);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 27378);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 27396);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 27449);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 27658);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 27668);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 27918);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 27932);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 28005);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 31580);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 31627);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 31835);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 31933);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 31978);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 32539);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 32865);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 33203);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 33255);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 33283);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 33361);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 33558);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 33562);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 34398);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 40383);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 40699);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 40810);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 41048);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 41408);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 41660);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 41661);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 45784);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 45868);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 45884);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 46007);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 46047);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 46295);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 46298);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 46335);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 46679);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 46703);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 46764);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 47422);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 47427);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 47433);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 47445);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 47448);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 47489);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 47553);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 47663);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 47664);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 47776);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 47780);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 47791);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 47794);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 47803);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 47970);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 48014);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 48018);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 48077);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 48249);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 48257);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 48258);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 48390);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 48399);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 48462);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 48490);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 48645);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 48647);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 48649);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 48664);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 48668);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 48727);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 48731);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 48868);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 48958);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 49204);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 49242);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 49331);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 49369);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 49994);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 50072);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 50432);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 50653);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 50662);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 50693);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 50699);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 50800);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 50807);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 51196);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 51264);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 51319);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 51325);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 51646);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 51660);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 52232);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 52304);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 52347);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 52401);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 53040);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 53194);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 53557);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 53755);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 53819);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 63747);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 63894);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 64201);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 64932);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 64943);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 65095);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 65122);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 74649);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 74674);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 74832);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 79528);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 79682);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 79688);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 79709);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 79991);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 80003);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 84936);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 85338);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 85867);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 86206);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 110481);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 110666);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 110806);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 110935);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 111422);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 111461);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 111545);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 111684);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 112081);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 112338);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 112638);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 112654);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 112735);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 112815);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 112878);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 112882);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 112883);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 112885);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 112886);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 112887);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 112920);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 112923);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 112942);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 112961);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 112979);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 113125);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 114060);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 114113);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 114133);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 114225);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 114328);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 114329);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 114333);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 114568);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 114578);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 142542);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 142547);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 142558);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 142850);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 142871);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 143006);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 143017);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 143130);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 143210);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 143278);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 143393);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 143405);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 143476);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 143607);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 143682);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 143721);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 143817);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 144467);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 144852);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 144900);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 144902);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 144936);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 144937);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 145037);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 145040);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 145041);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 145125);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 145192);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 145335);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 145337);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 145339);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 145615);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 145656);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 145874);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 145914);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 145924);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 146067);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 146099);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 146403);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 146509);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 147729);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 147856);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 148049);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 148377);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 148534);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 148535);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 148685);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 148775);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 148844);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 149148);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 149699);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 149735);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 149737);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 149739);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 149741);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 150201);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 150343);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 150426);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 150700);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 150769);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 151061);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 151473);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 151853);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 151948);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 152021);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 152240);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 152355);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 152359);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 152363);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 152386);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 152440);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 152628);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 152786);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 153059);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 153079);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 153135);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 153438);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 153444);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 153494);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 153609);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 153733);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 154005);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 154319);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 154475);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 154733);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 154777);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 154839);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 154941);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 155505);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 155516);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 155524);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 155681);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 156043);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 156143);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 156145);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 156167);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 156251);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 156365);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 157231);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 157347);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 159127);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 159219);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 159835);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 160057);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 160209);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 160211);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 161077);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 161535);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 162007);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 162041);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 162177);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 162447);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 163271);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 163297);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 164391);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 164393);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 164523);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 164597);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 165237);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 166383);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 166941);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 167031);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 168053);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 168433);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 168543);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 168749);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 169013);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 169845);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 169917);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 171169);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 174389);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 174391);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 174449);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 175545);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 177813);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 177833);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 177897);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 177913);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 178303);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 178551);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 179051);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 179125);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 179385);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 179693);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 181325);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 182139);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 182293);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 182349);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 182365);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 182863);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 182969);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 183013);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 183251);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 183315);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 183321);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 183325);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 183621);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 183625);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 183637);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 183657);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 183795);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 184299);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 185013);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 185075);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 185235);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 185677);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 185875);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 186089);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 186153);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 186553);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 186751);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 189471);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 189509);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 189593);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 189947);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 190889);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 192947);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 193755);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 193967);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 194025);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 194399);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 194403);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 194565);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 195725);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 196171);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 196189);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 196829);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 197443);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 197731);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 197767);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 198129);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 198523);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 198687);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 198777);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 199431);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 199769);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 199801);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 199919);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 199927);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 199937);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 199975);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 200189);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 200819);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 201253);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 202043);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 202071);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 202333);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 202395);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 202429);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 202607);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 203101);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 203917);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 204023);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 204025);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 204141);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 204609);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 204611);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 204787);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 205197);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 205395);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 205903);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 206523);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 206727);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 206801);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 207205);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 207249);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 208677);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 208741);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 210631);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 210769);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 211343);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 211415);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 211481);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 211603);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 211757);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 212149);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 212309);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 212461);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 212575);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 212611);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 212647);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 213121);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 213307);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 213397);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 213457);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 213569);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 213611);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 214387);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 214705);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 215649);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 215859);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 216511);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 216657);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 216771);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 217135);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 217293);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 217465);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 217549);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 217621);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 217627);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 217777);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 218061);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 218129);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 218757);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 218953);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 218957);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 219625);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 219695);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 219855);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 219929);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 220219);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 220727);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 220831);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 221061);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 221187);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 221573);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 222115);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 222659);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 223153);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 223155);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 223635);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 223749);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 224217);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 224521);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 225531);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 225581);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 226157);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 226165);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 226347);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 226669);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 226933);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 227783);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 227935);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 227957);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 229403);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 229559);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 230695);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 231125);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 231297);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 231725);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 231755);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 232191);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 232797);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 232949);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 233529);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 234331);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 234665);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 235231);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 235455);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 235517);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 235869);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 235879);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 236941);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 237931);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 238003);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 238407);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 238725);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 238861);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 239327);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 240279);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 240925);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 241131);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 242001);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 242445);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 242929);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 244305);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 244351);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 245085);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 245913);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 245945);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 245967);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 246545);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 246571);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 247549);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 248041);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 248191);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 248385);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 248413);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 250517);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 250531);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 251107);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 251807);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 252095);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 252399);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 252859);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 253361);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 253901);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 254331);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 254677);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 254939);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 255655);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 255883);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 257147);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 257373);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 257401);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 258537);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 258553);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 259015);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 259021);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 259307);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 259827);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 260977);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 261107);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 261245);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 261801);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 261827);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 261975);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 262161);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 270981);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 271349);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 271571);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 272309);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 272809);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 272829);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 273281);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 273321);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 273525);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 273717);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 273971);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 274043);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 274275);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 275037);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 275197);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 276747);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 279601);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 280113);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 280165);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 280167);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 280349);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 281391);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 282013);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 282637);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 282805);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 283249);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 283595);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 283985);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 284315);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 288115);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 290155);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 292285);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 293033);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 293765);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 294011);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 294433);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 295203);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 296783);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 297957);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 298405);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 298837);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 299381);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 300165);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 300463);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 306897);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 307531);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 307609);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 308227);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 308811);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 310475);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 311171);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 314409);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 314973);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 317315);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 317963);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 317995);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 318289);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 321545);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 324087);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 324135);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 325063);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 326649);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 327043);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 327861);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 330843);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 331895);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 332519);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 354595);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 354683);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 355081);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 355755);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 360931);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 362753);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 364377);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 366783);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 367577);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 367697);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 367883);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 367991);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 368153);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 369051);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 370261);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 370343);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 370411);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 370597);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 370685);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 370711);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 372895);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 373289);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 373379);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 402501);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 403327);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 403371);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 404719);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 406479);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 406575);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 406759);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 407603);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 408085);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 409613);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 410547);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 411201);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 411395);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 411497);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 411531);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 411791);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 413145);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 413203);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 415201);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 415523);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 415605);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 415739);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 416127);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 416527);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 416589);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 416995);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 417077);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 417425);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 418769);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 418935);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 419033);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 419037);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 419263);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 421185);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 421895);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 422141);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 423721);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 424081);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 424177);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 424503);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 425425);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 425555);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 426403);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 426989);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 427231);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 427499);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 429751);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 432517);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 432829);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 443303);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 444413);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 445011);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 448533);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 448813);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 449693);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 451273);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 452849);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 454251);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 454561);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 454665);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 455535);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 455955);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 456351);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 456513);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 460341);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 463979);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 466043);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 467717);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 469073);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 469121);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 470537);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 470751);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 471259);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 471575);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 471779);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 472079);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 475611);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 476013);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 476175);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 477307);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 478375);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 478795);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 480567);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 480737);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 481069);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 481817);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 484559);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 484905);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 485389);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 486871);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 486873);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 486937);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 486953);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 487641);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 487661);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 488103);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 488701);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 490423);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 491699);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 491887);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 493435);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 493923);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 493985);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 494763);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 495439);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 495465);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 496813);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 497361);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 499597);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 501111);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 501567);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 502001);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 503605);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 504521);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 505165);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 505595);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 505859);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 507597);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 510027);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 510303);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 512025);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 512067);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 512403);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 517583);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 517597);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 518791);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 521331);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 522685);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 524379);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 525205);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 525323);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 529027);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 532357);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 533281);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 534007);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 535627);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 537217);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 537679);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 538093);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 538513);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 539369);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 540977);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 541293);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 541755);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 542821);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 545367);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 548147);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 550669);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 550967);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 559269);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 560095);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 560863);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 561415);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 565173);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 567681);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 567735);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 568489);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 569135);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 573905);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 574165);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 575497);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 577937);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 578381);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 578757);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 578825);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 578915);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 579399);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 579813);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 580445);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 592473);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 601177);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 602331);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 602421);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 606243);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 606305);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 607117);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 608901);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 609131);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 609185);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 609663);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 609665);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 609669);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 609995);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 611917);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 612941);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 612965);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 613101);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 613493);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 616323);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 617801);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 617833);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 618505);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 618559);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 621539);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 625901);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 626025);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 626085);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 626253);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 626819);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 626999);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 628517);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 629125);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 629451);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 630655);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 631569);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 632045);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 632083);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 632569);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 632589);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 632677);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 632685);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 633815);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 634333);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 636085);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 639127);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 643749);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 660343);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 664703);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 675091);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 684889);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 685413);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 685825);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 686807);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 687857);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 688007);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 689147);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 690863);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 693507);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 694491);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 695741);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 700025);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 701701);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 706971);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 707789);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 707795);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 707989);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 713343);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 713425);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 713471);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 716223);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 716275);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 717665);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 718933);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 720587);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 722995);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 723547);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 723623);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 724507);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 725099);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 725785);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 726687);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 733743);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 734939);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 736383);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 737237);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 737737);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 737925);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 738541);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 738697);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 740219);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 740617);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 741217);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 743295);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 745233);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 745705);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 776333);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 776837);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 792977);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 793807);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 798353);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 805571);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 807217);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 807231);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 808721);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 832811);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 834293);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 834619);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 836787);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 838721);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 839549);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 839837);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 841411);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 841593);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 841971);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 846687);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 847713);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 847905);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 852971);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 853295);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 853799);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 854447);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 854451);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 857807);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 858145);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 859997);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 860369);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 860507);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 862531);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 862545);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 862907);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 864251);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 864561);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 870157);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 872003);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 872851);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 873101);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 873385);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 874293);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 878331);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 879253);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 880149);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 884245);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 885693);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 886169);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 886923);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 890533);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 890647);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 892671);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 892751);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 911799);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 924793);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 925095);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 926913);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 928393);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 929841);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 930161);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 930615);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 934373);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 938671);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 939041);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1105493);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1219171);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1936511);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3000371);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3008403);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3574065);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3748887);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3794985);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3795841);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3799115);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3799173);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3799587);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3812995);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3831231);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3835637);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3866781);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3867703);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3955813);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3974293);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3978001);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3979027);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3981367);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3985581);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3989771);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4003377);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4004887);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4005953);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4022955);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4022977);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4048625);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4188097);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4202843);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4204847);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4213813);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4224691);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4228801);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4234729);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4235751);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4237711);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4238147);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4243635);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4244853);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4245195);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4245251);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4246951);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4247083);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4249975);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4250493);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4256997);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4258443);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4259871);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4267275);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4267617);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4269901);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4271555);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4275489);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4276361);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4283907);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4285259);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4288551);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4294017);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4307205);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4401601);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4406879);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4408565);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4416483);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4423495);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4424515);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4427231);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4428301);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4428771);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4431443);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4435235);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4435237);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4436761);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4439829);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4440139);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4440205);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4440483);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4440587);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4469177);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4481399);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4488819);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4509313);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4509765);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4510553);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4510557);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4511355);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4524605);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4525341);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4534193);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4534305);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4539407);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4540893);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4581269);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4581507);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4598395);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4630457);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4642827);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4655747);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4678387);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4681523);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4698843);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4708201);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4712245);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4712403);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4712983);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4732457);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4738243);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4741611);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4765359);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4765385);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4765577);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4766125);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4766405);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4773221);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4776729);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4777447);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4784973);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4807177);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4820811);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4827915);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4828741);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4835051);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4842649);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4851111);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4877037);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4877879);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4884071);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4884089);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4886121);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4888849);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4898665);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4907867);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4916839);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4952659);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4955375);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4956901);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4957929);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4958627);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4964815);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4966851);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4988569);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4989679);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5003355);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5003535);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5012119);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5013437);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5018565);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5018831);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5018963);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5023305);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5025027);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5026491);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5033337);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5036755);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5036903);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5040313);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5043271);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5046069);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5046775);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5047129);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5058721);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5074117);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5084265);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5085907);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5095183);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5095619);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5097039);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5098843);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5099183);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5104653);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5109603);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5124791);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5132069);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5143951);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5152551);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5156931);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5160827);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5166107);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5166975);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5167307);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5173051);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5173455);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5178283);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5178681);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5179953);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5180595);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5180899);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5180961);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5181029);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5181975);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5182155);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5191837);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5195449);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5195453);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5196303);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5200629);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5202469);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5207801);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5209239);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5211067);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5211389);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5211409);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5211449);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5211657);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5212315);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5217519);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5217537);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5219673);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5221825);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5222401);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5224013);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5224641);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5225483);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5225873);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5227303);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5227647);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5227657);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5228261);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5234459);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5235671);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5242323);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5244009);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5244477);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5246949);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5249391);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5258881);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5258943);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5259865);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5259909);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5265175);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5267939);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5268289);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5272071);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5275107);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5305193);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5309795);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5310901);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5312311);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5332317);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5333835);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5334715);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5337041);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5337417);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5337837);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5347121);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5351035);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5354313);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5365729);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5367201);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5375543);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5378043);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5380019);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5380365);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5381089);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5386443);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5396813);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5402475);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5402543);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5402879);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5406107);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5413627);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5465099);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5505533);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5506393);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5534927);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5624299);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5647115);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5647959);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5656957);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5658771);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5659829);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5660705);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5677653);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5678587);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5696237);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5706641);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5707797);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5714829);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5715999);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5716001);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5716005);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5717579);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5722581);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5728387);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5744435);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5745605);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5778039);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6244549);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6275103);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6688165);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6993527);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7243965);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7244965);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7247911);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7270469);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7276487);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7278655);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7281287);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7281291);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7281295);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7281303);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7281335);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7281339);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7281345);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7281347);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7281349);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7281351);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7281355);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7281357);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7281369);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7281373);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7281375);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7281377);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7281379);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7281381);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7281401);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7282123);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7283143);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7288833);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7290005);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7293039);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7294005);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7303429);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7304183);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7306583);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7307977);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7309383);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7309395);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7309403);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7309405);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7309409);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7309415);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7309423);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7309431);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7309439);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7309441);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7309443);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7324269);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7337473);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7339545);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7355373);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7357047);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7358189);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7358195);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7363505);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7367537);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7368269);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7368299);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7378235);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7380233);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7380859);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7400077);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7406091);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7406365);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7412627);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7414643);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7457291);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7481997);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7491535);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7491883);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7520663);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7798515);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7812699);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7817261);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7818543);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7821583);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7826699);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7840377);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7842899);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7864221);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7878711);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7879249);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7880761);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7896671);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7896693);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7899451);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7899465);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7900359);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7903429);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7905793);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7917161);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7917221);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7918509);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7918573);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7926521);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7958291);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7980869);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8046673);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8047575);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8059993);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8062079);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8062221);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8081391);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8081583);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8091701);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8117077);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8120873);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8126075);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8130707);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8137481);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8168527);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8173499);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8173763);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8175123);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8178777);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8181541);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8185209);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8189173);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8191055);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8194775);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8198669);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8199089);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8202658);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8202712);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8204070);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8204610);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8205594);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8207848);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8210142);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8212352);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8212461);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8213764);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8213988);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8214366);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8215026);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8216940);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8217148);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8218395);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8220858);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8222284);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8222406);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8222587);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8222890);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8225973);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8227425);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8227745);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8228657);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8229425);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8230451);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8232231);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8232252);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8232372);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8232474);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8232840);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8240097);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8240480);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8241022);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8241226);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8241507);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8242534);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8245106);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8245236);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8245251);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8245521);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8246361);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8247976);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8248965);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8249145);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8250912);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8251022);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8252318);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 316);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 320);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 917);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 918);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 925);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 933);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 934);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 935);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 936);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 941);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 958);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 959);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 975);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 977);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 981);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 984);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1008);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1192);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1508);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1581);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1582);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1584);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1591);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1592);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1594);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1595);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1625);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1702);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1778);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1794);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1795);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1796);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1818);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1840);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1884);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1946);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1951);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1954);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1966);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1973);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1974);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2015);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2150);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2223);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2306);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2307);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2322);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2328);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2551);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2640);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2663);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2667);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2757);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3862);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3863);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3864);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3865);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3866);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3868);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3869);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4077);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4227);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4386);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4387);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4388);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4399);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4400);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4421);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4422);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4441);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4546);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4550);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4551);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4553);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4554);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4558);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4559);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4560);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4561);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5015);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5164);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5188);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5189);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5190);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5191);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5192);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5250);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5337);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5340);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5341);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5342);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5404);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5451);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5602);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5873);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6070);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6179);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6526);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6568);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6826);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6827);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7741);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8039);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8047);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8060);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8061);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8074);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8093);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8095);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8129);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8142);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8214);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8215);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8313);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8337);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8338);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8339);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8350);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8352);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8355);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8357);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8370);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8374);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8387);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8411);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8413);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8431);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8595);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8597);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8895);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8977);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9983);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10068);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10382);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10389);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10416);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10418);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10570);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10803);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11033);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11313);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11319);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11322);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11326);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11327);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11332);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11333);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11334);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11347);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11375);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11601);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12884);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15074);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16004);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17208);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 18328);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 20766);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 20824);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 20908);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 21054);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 21074);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 21134);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 21166);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 21268);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 21298);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 21346);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 21356);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 21382);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 21442);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 21496);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 22998);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 23054);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 23120);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 24002);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 24024);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 24064);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 24306);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 24832);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 25036);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 26568);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 27468);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 27542);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 27548);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 27550);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 27562);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 27570);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 27572);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 27600);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 27604);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 27608);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 27612);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 28432);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 28670);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 28794);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 28806);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 28814);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 28822);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 28834);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 28856);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 33466);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 44472);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 44824);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 46516);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 49372);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 49384);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 49516);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 49524);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 49532);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 49650);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 52842);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 53050);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 53562);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 53582);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 53620);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 54276);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 54290);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 54302);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 54316);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 54330);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 54344);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 54362);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 54412);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 54430);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 54438);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 54452);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 54466);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 54500);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 54514);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 56009);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 67230);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 67309);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 67329);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 67485);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 67647);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 67703);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 68140);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 68576);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 68747);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 68840);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 69032);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 69118);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 69482);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 69498);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 915);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 931);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 976);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1520);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1686);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1703);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1789);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1801);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1815);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1846);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1882);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1883);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1975);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2549);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4221);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4384);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6000);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8322);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8371);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8594);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11312);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11603);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15078);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17166);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 27498);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 27616);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 44792);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 54042);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
