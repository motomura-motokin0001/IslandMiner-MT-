using UnityEngine;

public static class NumberFormatter
{
    public static string FormatNumber(long number)
    {
        // 1,000未満はそのまま
        if (number < 1000)
            return number.ToString();

        // 1,000以上の数値を略記に変換
        if (number < 1_000_000)
            return (number / 1000f).ToString("0.#") + "K";  // 千の位（K）

        if (number < 1_000_000_000)
            return (number / 1_000_000f).ToString("0.#") + "M";  // 百万（M）

        return (number / 1_000_000_000f).ToString("0.#") + "B";  // 十億（Billion）
    }

    public static string FormatTime(int totalSeconds)
    {
        // ① 日・時間・分・秒をそれぞれ計算
        int days = totalSeconds / 86400; // 1日は86400秒
        int hours = (totalSeconds % 86400) / 3600; // 残りを1時間(3600秒)で割る
        int minutes = (totalSeconds % 3600) / 60;  // 残りを1分(60秒)で割る
        int seconds = totalSeconds % 60;           // 残りが秒

        // ② 文字列を整形
        string result = "";

        if (days > 0) result += days + "日 ";
        if (hours > 0 || days > 0) result += hours + "時間 ";
        if (minutes > 0 || hours > 0 || days > 0) result += minutes + "分 ";
        result += seconds + "秒";

        return result.Trim();
    }
}
