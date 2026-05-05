using JankenCore;

namespace JankenCore.Tests;

public class JankenGameTests
{
    // --- 勝利パターン ---

    [Fact]
    public void Judge_RockVsScissors_ReturnsWin()
    {
        var result = JankenGame.Judge(Hand.Rock, Hand.Scissors);
        Assert.Equal(GameResult.Win, result);
    }

    [Fact]
    public void Judge_ScissorsVsPaper_ReturnsWin()
    {
        var result = JankenGame.Judge(Hand.Scissors, Hand.Paper);
        Assert.Equal(GameResult.Win, result);
    }

    [Fact]
    public void Judge_PaperVsRock_ReturnsWin()
    {
        var result = JankenGame.Judge(Hand.Paper, Hand.Rock);
        Assert.Equal(GameResult.Win, result);
    }

    // --- 敗北パターン ---

    [Fact]
    public void Judge_ScissorsVsRock_ReturnsLose()
    {
        var result = JankenGame.Judge(Hand.Scissors, Hand.Rock);
        Assert.Equal(GameResult.Lose, result);
    }

    [Fact]
    public void Judge_PaperVsScissors_ReturnsLose()
    {
        var result = JankenGame.Judge(Hand.Paper, Hand.Scissors);
        Assert.Equal(GameResult.Lose, result);
    }

    [Fact]
    public void Judge_RockVsPaper_ReturnsLose()
    {
        var result = JankenGame.Judge(Hand.Rock, Hand.Paper);
        Assert.Equal(GameResult.Lose, result);
    }

    // --- 引き分けパターン ---

    [Theory]
    [InlineData(Hand.Rock)]
    [InlineData(Hand.Scissors)]
    [InlineData(Hand.Paper)]
    public void Judge_SameHand_ReturnsDraw(Hand hand)
    {
        var result = JankenGame.Judge(hand, hand);
        Assert.Equal(GameResult.Draw, result);
    }
}
