using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord;
using Discord.Commands;
using Discord.Interactions;

namespace ZoteBote.Modules
{
    public class PreceptModule : ModuleBase<SocketCommandContext>
    {
        [Command("precept")]
        [Alias("p")]
        [Discord.Commands.Summary("Gives you a random precept. Interpret it well, cur!")]
        public async Task GetPrecept(
            [Discord.Commands.Summary("Choose a precept you want to read. If it's a non-existent precept, I'll give you a random one!")]
            int precept = 0)
        {
            if (precept < 1 || precept > 57)
            {
                precept = new Random().Next(1, 57);
            }
            await Context.Channel.SendMessageAsync(GetStringPrecept(precept));
        }

        [SlashCommand("precept", "Gives you a random precept. Interpret it well, cur!")]
        public async Task GetSlashPrecept(
            [Discord.Interactions.Summary("precept", "Choose a precept you want to read. I'll give any precept you want!")]
            [MinValue(1)]
            [MaxValue(57)]
            int precept = 0)
        {
            if (precept < 1 || precept > 57)
            {
                precept = new Random().Next(1, 57);
            }
            await Context.Channel.SendMessageAsync(GetStringPrecept(precept));
        }

        private string GetStringPrecept(int precept)
        {
            switch (precept)
            {
                case 1:
                    return "Precept One: 'Always Win Your Battles'.\nLosing a battle earns you nothing and teaches you nothing. Win your battles, or don't engage in them at all!";
                case 2:
                    return "Precept Two: 'Never Let Them Laugh at You'.\nFools laugh at everything, even at their superiors. But beware, laughter isn't harmless! Laughter spreads like a disease, and soon everyone is laughing at you.\nYou need to strike at the source of this perverse merriment quickly to stop it from spreading.";
                case 3:
                    return "Precept Three: 'Always Be Rested'.\nFighting and adventuring take their toll on your body.When you rest, your body strengthens and repairs itself. The longer you rest, the stronger you become.";
                case 4:
                    return "Precept Four: 'Forget Your Past'.\nThe past is painful, and thinking about your past can only bring you misery. Think about something else instead, such as the future, or some food.";
                case 5:
                    return "Precept Five: 'Strength Beats Strength'.\nIs your opponent strong? No matter! Simply overcome their strength with even more strength, and they'll soon be defeated.";
                case 6:
                    return "Precept Six: 'Choose Your Own Fate'.\nOur elders teach that our fate is chosen for us before we are even born. I disagree.";
                case 7:
                    return "Precept Seven: 'Mourn Not the Dead'.\nWhen we die, do things get better for us or worse? There's no way to tell, so we shouldn't bother mourning. Or celebrating for that matter.";
                case 8:
                    return "Precept Eight: 'Travel Alone'.\nYou can rely on nobody, and nobody will always be loyal. Therefore, nobody should be your constant companion.";
                case 9:
                    return "Precept Nine: 'Keep Your Home Tidy'.\nYour home is where you keep your most prized possession - yourself. Therefore, you should make an effort to keep it nice and clean.";
                case 10:
                    return "Precept Ten: 'Keep Your Weapon Sharp'.\nI make sure that my weapon, 'Life Ender', is kept well - sharpened at all times. This makes it much easier to cut things.";
                case 11:
                    return "Precept Eleven: 'Mothers Will Always Betray You'.\nThis precept explains itself.";
                case 12:
                    return "Precept Twelve: 'Keep Your Cloak Dry'.\nIf your cloak gets wet, dry it as soon as you can. Wearing wet cloaks is unpleasant, and can lead to illness.";
                case 13:
                    return "Precept Thirteen: 'Never Be Afraid'.\nFear can only hold you back. Facing your fears can be a tremendous effort. Therefore, you should just not be afraid in the first place.";
                case 14:
                    return "Precept Fourteen: 'Respect Your Superiors'.\nIf someone is your superior in strength or intellect or both, you need to show them your respect. Don't ignore them or laugh at them.";
                case 15:
                    return "Precept Fifteen: 'One Foe, One Blow'.\nYou should only use a single blow to defeat an enemy. Any more is a waste. Also, by counting your blows as you fight, you'll know how many foes you've defeated.";
                case 16:
                    return "Precept Sixteen: 'Don't Hesitate'.\nOnce you've made a decision, carry it out and don't look back. You'll achieve much more this way.";
                case 17:
                    return "Precept Seventeen: 'Believe In Your Strength'.\nOthers may doubt you, but there's someone you can always trust. Yourself. Make sure to believe in your own strength, and you will never falter.";
                case 18:
                    return "Precept Eighteen: 'Seek Truth in the Darkness'.\nThis precept also explains itself.";
                case 19:
                    return "Precept Nineteen: 'If You Try, Succeed'.\nIf you're going to attempt something, make sure you achieve it. If you do not succeed, then you have actually failed! Avoid this at all costs.";
                case 20:
                    return "Precept Twenty: 'Speak Only the Truth'.\nWhen speaking to someone, it is courteous and also efficient to speak truthfully. Beware though that speaking truthfully may make you enemies. This is something you'll have to bear.";
                case 21:
                    return "Precept Twenty-One: 'Be Aware of Your Surroundings'.\nDon't just walk along staring at the ground! You need to look up every so often, to make sure nothing takes you by surprise.";
                case 22:
                    return "Precept Twenty-Two: 'Abandon the Nest'.\nAs soon as I could, I left my birthplace and made my way out into the world. Do not linger in the nest. There is nothing for you there.";
                case 23:
                    return "Precept Twenty-Three: 'Identify the Foe's Weak Point'.\nEvery foe you encounter has a weak point, such as a crack in their shell or being asleep. You must constantly be alert and scrutinising your enemy to detect their weakness!";
                case 24:
                    return "Precept Twenty-Four: 'Strike the Foe's Weak Point'.\nOnce you have identified your foe's weak point as per the previous precept, strike it. This will instantly destroy them.";
                case 25:
                    return "Precept Twenty-Five: 'Protect Your Own Weak Point'.\nBe aware that your foe will try to identify your weak point, so you must protect it. The best protection? Never having a weak point in the first place.";
                case 26:
                    return "Precept Twenty-Six: 'Don't Trust Your Reflection'.\nWhen peering at certain shining surfaces, you may see a copy of your own face. The face will mimic your movements and seems similar to your own, but I don't think it can be trusted.";
                case 27:
                    return "Precept Twenty-Seven: 'Eat As Much As You Can'.\nWhen having a meal, eat as much as you possibly can. This gives you extra energy, and means you can eat less frequently.";
                case 28:
                    return "Precept Twenty-Eight: 'Don't Peer Into the Darkness'.\nIf you peer into the darkness and can't see anything for too long, your mind will start to linger over old memories. Memories are to be avoided, as per Precept Four.";
                case 29:
                    return "Precept Twenty-Nine: 'Develop Your Sense of Direction'.\nIt's easy to get lost when travelling through winding, twisting caverns. Having a good sense of direction is like having a magical map inside of your head. Very useful.";
                case 30:
                    return "Precept Thirty: 'Never Accept a Promise'.\nSpurn the promises of others, as they are always broken. Promises of love or betrothal are to be avoided especially.";
                case 31:
                    return "Precept Thirty-One: 'Disease Lives Inside of Dirt'.\nYou'll get sick if you spend too much time in filthy places. If you are staying in someone else's home, demand the highest level of cleanliness from your host.";
                case 32:
                    return "Precept Thirty-Two: 'Names Have Power'.\nNames have power, and so to name something is to grant it power. I myself named my nail 'Life Ender'. Do not steal the name I came up with! Invent your own!";
                case 33:
                    return "Precept Thirty-Three: 'Show the Enemy No Respect'.\nBeing gallant to your enemies is no virtue! If someone opposes you, they don't deserve respect or kindness or mercy.";
                case 34:
                    return "Precept Thirty-Four: 'Don't Eat Immediately Before Sleeping'.\nThis can cause restlessness and indigestion. It's just common sense.";
                case 35:
                    return "Precept Thirty-Five: 'Up is Up, Down is Down'.\nIf you fall over in the darkness, it can be easy to lose your bearing and forget which way is up. Keep this precept in mind!";
                case 36:
                    return "Precept Thirty-Six: 'Eggshells are brittle'.\nOnce again, this precept explains itself.";
                case 37:
                    return "Precept Thirty-Seven: 'Borrow, But Do Not Lend'.\nIf you lend and are repaid, you gain nothing. If you borrow but do not repay, you gain everything.";
                case 38:
                    return "Precept Thirty-Eight: 'Beware the Mysterious Force'.\nA mysterious force bears down on us from above, pushing us downwards. If you spend too long in the air, the force will crush you against the ground and destroy you. Beware!";
                case 39:
                    return "Precept Thirty-Nine: 'Eat Quickly and Drink Slowly'.\nYour body is a delicate thing and you must fuel it with great deliberation.Food must go in as fast as possible, but fluids at a slower rate.";
                case 40:
                    return "Precept Forty: 'Obey No Law But Your Own'.\nLaws written by others may inconvenience you or be a burden.Let your own desires be the only law.";
                case 41:
                    return "Precept Forty-One: 'Learn to Detect Lies'.\nWhen others speak, they usually lie.Scrutinise and question them relentlessly until they reveal their deceit.";
                case 42:
                    return "Precept Forty-Two: 'Spend Geo When You Have It'.\nSome will cling onto their Geo, even taking it into the dirt with them when they die. It is better to spend it when you can, so you can enjoy various things in life.";
                case 43:
                    return "Precept Forty-Three: 'Never Forgive'.\nIf someone asks forgiveness of you, for instance a brother of yours, always deny it. That brother, or whoever it is, doesn't deserve such a thing.";
                case 44:
                    return "Precept Forty-Four: 'You Can Not Breathe Water'.\nWater is refreshing, but if you try to breathe it you are in for a nasty shock.";
                case 45:
                    return "Precept Forty-Five: 'One Thing Is Not Another'.\nThis one should be obvious, but I've had others try to argue that one thing, which is clearly what it is and not something else, is actually some other thing, which it isn't. Stay on your guard!";
                case 46:
                    return "Precept Forty-Six: 'The World is Smaller Than You Think'.\nWhen young, you tend to think that the world is vast, huge, gigantic. It's only natural. Unfortunately, it's actually quite a lot smaller than that. I can say this, now having travelled everywhere in the land.";
                case 47:
                    return "Precept Forty-Seven: 'Make Your Own Weapon'.\nOnly you know exactly what is needed in your weapon. I myself fashioned 'Life Ender' from shellwood at a young age. It has never failed me. Nor I it.";
                case 48:
                    return "Precept Forty-Eight: 'Be Careful With Fire'.\nFire is a type of hot spirit that dances about recklessly. It can warm you and provide light, but it will also singe your shell if it gets too close.";
                case 49:
                    return "Precept Forty-Nine: 'Statues are Meaningless'.\nDo not honour them! No one has ever made a statue of you or I, so why should we pay them any attention?";
                case 50:
                    return "Precept Fifty: 'Don't Linger on Mysteries'.\nSome things in this world appear to us as puzzles. Or enigmas. If the meaning behind something is not immediately evident though, don't waste any time thinking about it. Just move on.";
                case 51:
                    return "Precept Fifty-One: 'Nothing is Harmless'.\nGiven the chance, everything in this world will hurt you. Friends, foes, monsters, uneven paths. Be suspicious of them all.";
                case 52:
                    return "Precept Fifty-Two: 'Beware the Jealousy of Fathers'.\nFathers believe that because they created us we must serve them and never exceed their capabilities. If you wish to forge your own path, you must vanquish your father. Or simply abandon him.";
                case 53:
                    return "Precept Fifty-Three: 'Do Not Steal the Desires of Others'.\nEvery creature keeps their desires locked up inside of themselves. If you catch a glimpse of another's desires, resist the urge to claim them as your own. It will not lead you to happiness.";
                case 54:
                    return "Precept Fifty-Four: 'If You Lock Something Away, Keep the Key'.\nNothing should be locked away for ever, so hold onto your keys. You will eventually return and unlock everything you hid away.";
                case 55:
                    return "Precept Fifty-Five: 'Bow to No-one'.\nThere are those in this world who would impose their will on others. They claim ownership over your food, your land, your body, and even your thoughts!\nThey have done nothing to earn these things. Never bow to them, and make sure to disobey their commands.";
                case 56:
                    return "Precept Fifty-Six: 'Do Not Dream'.\nDreams are dangerous things. Strange ideas, not your own, can worm their way into your mind. But if you resist those ideas, sickness will wrack your body! Best not to dream at all, like me.";
                case 57:
                    return "Precept Fifty-Seven: 'Obey All Precepts'.\nMost importantly, you must commit all of these precepts to memory and obey them all unfailingly. Including this one!";
                default:
                    return "That Precept, I'm afraid it doesn't exist, cur.";
            }
        }
    }
}
