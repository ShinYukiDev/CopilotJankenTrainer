namespace JankenCore;

/// <summary>じゃんけんゲームのロジック</summary>
public static class JankenGame
{
    /// <summary>
    /// プレイヤーの手とコンピュータの手から勝敗を判定する。
    /// </summary>
    /// <param name="player">プレイヤーの手</param>
    /// <param name="computer">コンピュータの手</param>
    /// <returns>プレイヤー視点の勝敗結果</returns>
    public static GameResult Judge(Hand player, Hand computer)
    {
        if (player == computer)
        {
            return GameResult.Draw;
        }

        return (player, computer) switch
        {
            (Hand.Rock, Hand.Scissors) => GameResult.Win,
            (Hand.Scissors, Hand.Paper) => GameResult.Win,
            (Hand.Paper, Hand.Rock) => GameResult.Win,
            _ => GameResult.Lose
        };
    }
}
