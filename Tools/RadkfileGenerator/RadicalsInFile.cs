﻿namespace RadkfileGenerator
{
    using System.Collections.Generic;
    
    public static class RadicalsInFile
    {
        public static List<(string character, int strokes, string alt)> OrderedRadicals => list;

        private static readonly List<(string character, int strokes, string alt)> list = new()
        {
            ("一", 1, ""),
            ("｜", 1, ""),
            ("丶", 1, ""),
            ("ノ", 1, ""),
            ("乙", 1, ""),
            ("亅", 1, ""),
            ("二", 2, ""),
            ("亠", 2, ""),
            ("人", 2, ""),
            ("化", 2, "2E85 ⺅"),
            ("个", 2, "2F09 ⼉ (not 201A2 𠆢?)"),
            ("儿", 2, ""),
            ("入", 2, ""),
            ("ハ", 2, ""),
            ("并", 2, "4E37  丷"),
            ("冂", 2, ""),
            ("冖", 2, ""),
            ("冫", 2, ""),
            ("几", 2, ""),
            ("凵", 2, ""),
            ("刀", 2, ""),
            ("刈", 2, "2E89 ⺉"),
            ("力", 2, ""),
            ("勹", 2, ""),
            ("匕", 2, ""),
            ("匚", 2, ""),
            ("十", 2, ""),
            ("卜", 2, ""),
            ("卩", 2, ""),
            ("厂", 2, ""),
            ("厶", 2, ""),
            ("又", 2, ""),
            ("マ", 2, ""),
            ("九", 2, ""),
            ("ユ", 2, ""),
            ("乃", 2, ""),
            ("乞", 2, "20089 𠂉"),
            ("込", 3, "2ECC ⻌"),
            ("口", 3, ""),
            ("囗", 3, ""),
            ("土", 3, ""),
            ("士", 3, ""),
            ("夂", 3, ""),
            ("夕", 3, ""),
            ("大", 3, ""),
            ("女", 3, ""),
            ("子", 3, ""),
            ("宀", 3, ""),
            ("寸", 3, ""),
            ("小", 3, ""),
            ("尚", 3, "2E8C ⺌"),
            ("尢", 3, ""),
            ("尸", 3, ""),
            ("屮", 3, ""),
            ("山", 3, ""),
            ("川", 3, ""),
            ("巛", 3, ""),
            ("工", 3, ""),
            ("已", 3, ""),
            ("巾", 3, ""),
            ("干", 3, ""),
            ("幺", 3, ""),
            ("广", 3, ""),
            ("廴", 3, ""),
            ("廾", 3, ""),
            ("弋", 3, ""),
            ("弓", 3, ""),
            ("ヨ", 3, ""),
            ("彑", 3, ""),
            ("彡", 3, ""),
            ("彳", 3, ""),
            ("忙", 3, "2E96 ⺖"),
            ("扎", 3, "2E97 ⺗ (not 2E98 ⺘?)"),
            ("汁", 3, "2EA1 ⺡"),
            ("犯", 3, "2EA8 ⺨"),
            ("艾", 3, "2EBE ⺾"),
            ("邦", 3, "2ECF ⻏"),
            ("阡", 3, "2ED9 ⻙ (not 2ED6 ⻖?)"),
            ("也", 3, ""),
            ("亡", 3, ""),
            ("及", 3, ""),
            ("久", 3, ""),
            ("老", 4, "2EB9 ⺹"),
            ("心", 4, ""),
            ("戈", 4, ""),
            ("戸", 4, ""),
            ("手", 4, ""),
            ("支", 4, ""),
            ("攵", 4, ""),
            ("文", 4, ""),
            ("斗", 4, ""),
            ("斤", 4, ""),
            ("方", 4, ""),
            ("无", 4, ""),
            ("日", 4, ""),
            ("曰", 4, ""),
            ("月", 4, ""),
            ("木", 4, ""),
            ("欠", 4, ""),
            ("止", 4, ""),
            ("歹", 4, ""),
            ("殳", 4, ""),
            ("比", 4, ""),
            ("毛", 4, ""),
            ("氏", 4, ""),
            ("气", 4, ""),
            ("水", 4, ""),
            ("火", 4, ""),
            ("杰", 4, "2EA3 ⺣"),
            ("爪", 4, ""),
            ("父", 4, ""),
            ("爻", 4, ""),
            ("爿", 4, ""),
            ("片", 4, ""),
            ("牛", 4, ""),
            ("犬", 4, ""),
            ("礼", 4, "2EAD ⺭"),
            ("王", 4, ""),
            ("元", 4, ""),
            ("井", 4, ""),
            ("勿", 4, ""),
            ("尤", 4, ""),
            ("五", 4, ""),
            ("屯", 4, ""),
            ("巴", 4, ""),
            ("毋", 4, ""),
            ("玄", 5, ""),
            ("瓦", 5, ""),
            ("甘", 5, ""),
            ("生", 5, ""),
            ("用", 5, ""),
            ("田", 5, ""),
            ("疋", 5, ""),
            ("疔", 5, "2F67 ⽧"),
            ("癶", 5, ""),
            ("白", 5, ""),
            ("皮", 5, ""),
            ("皿", 5, ""),
            ("目", 5, ""),
            ("矛", 5, ""),
            ("矢", 5, ""),
            ("石", 5, ""),
            ("示", 5, ""),
            ("禹", 5, "2F71 ⽱"),
            ("禾", 5, ""),
            ("穴", 5, ""),
            ("立", 5, ""),
            ("初", 5, "2EC2 ⻂"),
            ("世", 5, ""),
            ("巨", 5, ""),
            ("冊", 5, ""),
            ("母", 5, ""),
            ("買", 5, "2EB2 ⺲"),
            ("牙", 5, ""),
            ("瓜", 6, ""),
            ("竹", 6, ""),
            ("米", 6, ""),
            ("糸", 6, ""),
            ("缶", 6, ""),
            ("羊", 6, ""),
            ("羽", 6, ""),
            ("而", 6, ""),
            ("耒", 6, ""),
            ("耳", 6, ""),
            ("聿", 6, ""),
            ("肉", 6, ""),
            ("自", 6, ""),
            ("至", 6, ""),
            ("臼", 6, ""),
            ("舌", 6, ""),
            ("舟", 6, ""),
            ("艮", 6, ""),
            ("色", 6, ""),
            ("虍", 6, ""),
            ("虫", 6, ""),
            ("血", 6, ""),
            ("行", 6, ""),
            ("衣", 6, ""),
            ("西", 6, ""),
            ("臣", 7, ""),
            ("見", 7, ""),
            ("角", 7, ""),
            ("言", 7, ""),
            ("谷", 7, ""),
            ("豆", 7, ""),
            ("豕", 7, ""),
            ("豸", 7, ""),
            ("貝", 7, ""),
            ("赤", 7, ""),
            ("走", 7, ""),
            ("足", 7, ""),
            ("身", 7, ""),
            ("車", 7, ""),
            ("辛", 7, ""),
            ("辰", 7, ""),
            ("酉", 7, ""),
            ("釆", 7, ""),
            ("里", 7, ""),
            ("舛", 7, ""),
            ("麦", 7, ""),
            ("金", 8, ""),
            ("長", 8, ""),
            ("門", 8, ""),
            ("隶", 8, ""),
            ("隹", 8, ""),
            ("雨", 8, ""),
            ("青", 8, ""),
            ("非", 8, ""),
            ("奄", 8, ""),
            ("岡", 8, ""),
            ("免", 8, ""),
            ("斉", 8, ""),
            ("面", 9, ""),
            ("革", 9, ""),
            ("韭", 9, ""),
            ("音", 9, ""),
            ("頁", 9, ""),
            ("風", 9, ""),
            ("飛", 9, ""),
            ("食", 9, ""),
            ("首", 9, ""),
            ("香", 9, ""),
            ("品", 9, ""),
            ("馬", 10, ""),
            ("骨", 10, ""),
            ("高", 10, ""),
            ("髟", 10, ""),
            ("鬥", 10, ""),
            ("鬯", 10, ""),
            ("鬲", 10, ""),
            ("鬼", 10, ""),
            ("竜", 10, ""),
            ("韋", 10, ""),
            ("魚", 11, ""),
            ("鳥", 11, ""),
            ("鹵", 11, ""),
            ("鹿", 11, ""),
            ("麻", 11, ""),
            ("亀", 11, ""),
            ("滴", 11, "5547 啇"),
            ("黄", 11, ""),
            ("黒", 11, ""),
            ("黍", 12, ""),
            ("黹", 12, ""),
            ("無", 12, ""),
            ("歯", 12, ""),
            ("黽", 13, ""),
            ("鼎", 13, ""),
            ("鼓", 13, ""),
            ("鼠", 13, ""),
            ("鼻", 14, ""),
            ("齊", 14, ""),
            ("龠", 17, "")
        };
    }
}