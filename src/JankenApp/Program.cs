using JankenCore;

Console.WriteLine("=== じゃんけんゲーム ===");
Console.WriteLine("手を選んでください:");
Console.WriteLine("  1: グー (Rock)");
Console.WriteLine("  2: チョキ (Scissors)");
Console.WriteLine("  3: パー (Paper)");
Console.Write("入力 > ");

var input = Console.ReadLine()?.Trim();
if (!int.TryParse(input, out var choice) || choice < 1 || choice > 3)
{
    Console.WriteLine("無効な入力です。1, 2, 3 のいずれかを入力してください。");
    Console.WriteLine("Enterキーを押して終了してください...");
    Console.ReadLine();
    return;
}

var playerHand = (Hand)(choice - 1);

var random = new Random();
var computerHand = (Hand)random.Next(0, 3);

var result = JankenGame.Judge(playerHand, computerHand);

Console.WriteLine();
Console.WriteLine($"あなた   : {HandToJapanese(playerHand)}");
Console.WriteLine($"コンピュータ: {HandToJapanese(computerHand)}");
Console.WriteLine();
Console.WriteLine(result switch
{
    GameResult.Win => "結果: あなたの勝ち！🎉",
    GameResult.Lose => "結果: あなたの負け…😢",
    GameResult.Draw => "結果: 引き分け！🤝",
    _ => "結果: 不明"
});

Console.WriteLine();
Console.WriteLine("Enterキーを押して終了してください...");
Console.ReadLine();

static string HandToJapanese(Hand hand) => hand switch
{
    Hand.Rock => "グー ✊",
    Hand.Scissors => "チョキ ✌️",
    Hand.Paper => "パー 🖐️",
    _ => "不明"
};
