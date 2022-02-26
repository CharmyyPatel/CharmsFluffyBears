using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using CharmsFluffyBears.Data;
using System;
using System.Linq;

namespace CharmsFluffyBears.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new CharmsFluffyBearsContext(serviceProvider.GetRequiredService<DbContextOptions<CharmsFluffyBearsContext>>()))
            {
                if (context.FluffyBears.Any())
                {
                    return;
                }
                context.FluffyBears.AddRange(
                    new FluffyBears
                    {
                        ProductName = "Paddington Bear",
                        ProductDescription = "A happy result of bad weather. Author Michael Bond was huddling in a toy shop near Paddington station in 1956, avoiding the snow, when he spotted a lone teddy on a shelf and bought it for his wife. “Bears are a thing apart from all cuddly toys,” Bond decided and wrote his first Paddington Bear story in 10 days. The duffel-coated, marmalade sandwich-scoffing, a hard-staring stowaway from “darkest Peru” appeared in 20 more books. Bond, now 88, recently revealed he was at work on a new installment: an “origin story” comprising Paddington’s letters home to Aunt Lucy. There’s also an animated film coming this Christmas, with Colin Firth voicing the “very rare” bear.",
                        Size = "Medium",
                        Colour = "Brown",
                        Price = 8.90M
                    },
                    new FluffyBears
                    {
                        ProductName = "Winnie-the-Pooh",
                        ProductDescription = "Among A-list fictional bears, the one who went corporate. Created by AA Milne in the 1920s to amuse his son Christopher Robin, Winnie-the-Pooh, a slow-witted, accident-prone, daydreaming “Hunny” obsessive from Ashdown Forest in East Sussex, was licensed to Disney in the 60s. Out went the hyphens in Pooh’s name, in came expressive animated eyebrows and the syrupy voice of actor Sterling Holloway. Pooh has appeared in Disney films and TV shows ever since. Charming enough, but you have to go back to Milne’s early stories for this bear of the very little brain at his best. “If bears were bees,” he sang in 1926, “they’d build their nests at the bottom of trees”.",
                        Size = "Large",
                        Colour = "Pink",
                        Price = 8.15M
                    },
                    new FluffyBears
                    {
                        ProductName = "Bungle",
                        ProductDescription = "Anxious, clumsy and a tad camp, Bungle was a key character on long-running children’s TV show Rainbow, broadcast on ITV from 1972 to 1992 and conceived as a British Sesame Street. Initially a wolfish presence and later a cuddlier thing with a massive head, Bungle tended to feature in the writers’ more ambitious ideas. Possibly it was their intention to suggest he suffered from a mood disorder – in 1985’s What’s Wrong With Bungle?, the character could not be persuaded to speak for most of the episode. Finally, he clattered on set with a tea trolley and breathlessly insisted everybody eat cake. Shut it, Zippy.",
                        Size = "Small",
                        Colour = "Cyan",
                        Price = 7.99M
                    },
                    new FluffyBears
                    {
                        ProductName = "Baloo",
                        ProductDescription = "“Let me tell you something, little britches.” In Rudyard Kipling’s 1894 story collection The Jungle Book, he was described as “the sleepy brown bear”, most likely a sloth bear, who sternly taught man-cub Mowgli moral lessons and was named after “bhalu”, the Hindi word for bear. By the 1967 Disney film, Baloo was grey in colour and had lightened up personality-wise too, becoming fun-loving and famed for the Oscar-nominated song The Bare Necessities. He was played by wise-cracking, scatting jazz bandleader Phil Harris, who improvised his lines to appear more laidback. The character was later recycled as Little John in Disney’s Robin Hood, also played by Harris. You better believe it!",
                        Size = "Small",
                        Colour = "Red",
                        Price = 9.99M
                    },
                    new FluffyBears
                    {
                        ProductName = "Iorek Byrnison",
                        ProductDescription = "He has a name like a moody cop from a subtitled Scandi-drama but Iorek is way cooler than that: he’s a panserbjørn, or armoured polar bear. In Philip Pullman’s His Dark Materials trilogy, young heroine Lyra Belacqua helps rescue this formidable warrior from human enslavement. The brave bear becomes her loyal comrade and protector, even giving Lyra her new surname of Silvertongue. He’s a skilled sky-iron blacksmith who eventually returns from exile to reclaim his rightful position as king of Svalbard. In the 2007 film, The Golden Compass, he was voiced by Ian McKellen, while Dakota Blue Richards rode on the giant CGI bear’s back.",
                        Size = "Medium",
                        Colour = "Blue",
                        Price = 17M
                    },
                    new FluffyBears
                    {
                        ProductName = "Ted",
                        ProductDescription = "The only bear on this list who drinks beer, smokes cannabis, parties with prostitutes and gets caught having fuzzy sex in a supermarket. At least, as far as we know. Seth MacFarlane’s 2012 directorial debut is the sweet-but-sweary tale of a lonely boy who gets a teddy bear for Christmas, wishes it could come to life – and gets his dream granted by a falling star. Fast forward three decades and the pair are still best buddies, getting stoned in front of the TV. Starring Mark Wahlberg and Mila Kunis, this “romance v bromance” story became the highest-grossing live-action comedy of all time. A sequel’s in the pipeline for next summer.",
                        Size = "Small",
                        Colour = "Orange",
                        Price = 5M
                    },
                    new FluffyBears
                    {
                        ProductName = "Rupert",
                        ProductDescription = "The most dapper bear here is always impeccably turned out in red sweater and yellow checked trousers with matching scarf. Rupert was created by artist Mary Tourtel and first appeared in the Daily Express in 1920, originally depicted as a brown bear but soon changed to white to cut printing costs. Nearly a century later, his comic strip is still going strong. Each story begins in the idyllic village of Nutwood, where Rupert sets out on a small errand for his mother. These invariably develop into magical adventures, with Rupert accompanied by his best friend, Bill Badger, before everyone arrives back home in time for tea.",
                        Size = "Large",
                        Colour = "Green",
                        Price = 3.99M
                    },
                    new FluffyBears
                    {
                        ProductName = "John Lewis bear",
                        ProductDescription = "Just pipping George the Hofmeister bear (“For great lager, follow the bear”) and the Coca-Cola polar bears as advertising’s top ursine star, this nameless newcomer shot to fame after appearing in department store John Lewis’s £7m 2013 festive campaign, “The Bear & the Hare”. The hibernating gentle giant had never seen Christmas, so his floppy-eared friend bought him an alarm clock as a gift. Soundtracked by Lily Allen’s stripped-back cover of Keane’s Somewhere Only We Know, which promptly went to Number 1, the soppy two-minute animation has been viewed 12.5m times and counting on YouTube. It proved so popular that the retail chain sold out of Bear & Hare merchandise within days.",
                        Size = "Medium",
                        Colour = "Yellow",
                        Price = 6.99M
                    },
                    new FluffyBears
                    {
                        ProductName = "Yogi",
                        ProductDescription = "Not to be confused with baseball legend Yogi Berra or Scottish inventor John Logie Baird, Yogi Bear made his debut on an edition of The Huckleberry Hound Show in 1958 but became a breakout star in his own right. Based on jovial neighbour Ed from The Honeymooners (who also inspired Barney Rubble), Yogi lived with his sidekick Boo-Boo in Jellystone Park, where they’d try to steal “pic-a-nic baskets” while evading arch foe Ranger Smith. Yogi was one of several Hanna-Barbera characters to wear a collar, meaning the studio could cunningly save on frames by keeping his body static and only redrawing his head as he spoke. Smarter than the average bear indeed.",
                        Size = "Large",
                        Colour = "Gray",
                        Price = 11.99M
                    },
                    new FluffyBears
                    {
                        ProductName = "Fozzie",
                        ProductDescription = "“Good grief! The comedian’s a bear!” With his polka-dot scarf, pork-pie hat and endless supply of bad jokes, Fozzie is Kermit’s best friend and The Muppets’ resident vaudevillian standup – hence he’s the main object of Statler and Waldorf’s heckles. However, the big-hearted, orangey-brown bear remains perpetually upbeat. He also plays piano, helps out backstage and regularly gets paired with Rowlf the dog for sketches. Fozzie’s name is often mistakenly thought to be a play on puppeteer Frank Oz (F Oz) but he was actually named after special effects designer Faz Fazakas, who created his ear-waggling mechanism. Wocka wocka!",
                        Size = "Small",
                        Colour = "White",
                        Price = 7M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
