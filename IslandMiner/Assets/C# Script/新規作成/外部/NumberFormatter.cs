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
}
