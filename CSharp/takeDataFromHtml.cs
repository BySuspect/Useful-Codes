            string str = "<div class=\"bsx\"><a href=\"https://manga.tempestfansub.com/manga/i-became-the-strongest-with-the-failure-frame-abnormal-state-skill-as-i-devastated-everything/\" title=\"I Became the Strongest With the Failure Frame &#8220;Abnormal State Skill&#8221; as I Devastated Everything\"><div class=\"limit\"><div class=\"ply\"></div><span class=\"type Manga\">Manga</span><img src=\"https://i2.wp.com/manga.tempestfansub.com/wp-content/uploads/2021/07/cover-1.jpg?resize=165,225\" class=\"ts-post-image wp-post-image attachment-medium size-medium\" loading=\"lazy\"></div><div class=\"bigor\"><div class=\"tt\">I Became the Strongest With the Failure Frame &#8220;Abnormal State Skill&#8221; as I Devastated Everything </div><div class=\"adds\"><div class=\"epxs\">Bölüm 25</div><div class=\"rt\"><div class=\"rating\"><div class=\"rating-prc\"><div class=\"rtp\"><div class=\"rtb\"><span style=\"width:73%\"></span></div></div></div><div class=\"numscore\">7.3</div></div></div></div></div></a></div>";
            var result = str.Split('\"');
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
            var t = result[26].Split('>', '<');
            foreach (var item in t)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
