using Sunny.UI;
using System;
using System.Globalization;

namespace EndDemo_02
{
    public partial class Form1 : UIForm
    {
        public Form1()
        {
            InitializeComponent();
            BindSliderPairs();
        }
        #region 滑块绑定
        /// <summary>
        /// 防止"滑块改变→写数值框"和"数值框改变→移滑块"互相触发形成死循环。
        /// </summary>
        private bool syncing;
        /// <summary>
        /// 把两个页签里所有"阈值滑条 + 数值框"绑定起来。
        /// 拖动滑条 → 数值框显示对应数值；数值框输入 → 滑条移到对应位置。
        /// </summary>
        private void BindSliderPairs()
        {
            // ---------- 页签2：手眼标定（4 组） ----------
            BindSlider(trbMean, txtMean, 1.0, "0");                     // 均值阈值 0 ~ 500
            BindSlider(trbDyn, txtDyn, 1.0, "0");                       // 动态阈值 0 ~ 30
            BindSlider(trbAreaMax, txtAreaMax, 1.0, "0");               // 面积上限 0 ~ 15000000
            BindSlider(trbAreaMin, txtAreaMin, 1.0, "0");               // 面积下限 0 ~ 6000

            // ---------- 页签3：多产品定位抓取（9 组） ----------
            BindSlider(trbMeanTh, txtMeanTh, 1.0, "0");                 // 均值阈值 0 ~ 500
            BindSlider(trbAreaMaxTh, txtAreaMaxTh, 1.0, "0");           // 面积上限 0 ~ 100000
            BindSlider(trbDynTh, txtDynTh, 1.0, "0");                   // 动态阈值 0 ~ 200
            BindSlider(trbAreaMinTh, txtAreaMinTh, 1.0, "0");           // 面积下限 0 ~ 2000
            BindSlider(trbTplContrast, txtTplContrast, 1.0, "0");       // 模板对比度 0 ~ 100
            BindSlider(trbProdContrast, txtProdContrast, 1.0, "0");     // 产品对比度 0 ~ 100
            BindSlider(trbMinScore, txtMinScore, 0.01, "0.##");         // 最小得分 0 ~ 100 → 0.00 ~ 1.00
            BindSlider(trbGreedy, txtGreedy, 0.01, "0.##");             // 贪婪度   0 ~ 100 → 0.00 ~ 1.00
            BindSlider(trbCover, txtCover, 0.01, "0.##");               // 遮盖度   0 ~ 100 → 0.00 ~ 1.00
        }

        /// <summary>
        /// 单个"滑条 ↔ 数值框"的双向绑定。
        /// </summary>
        /// <param name="bar">拖动条（Value 是 int）</param>
        /// <param name="box">数值框</param>
        /// <param name="scale">
        /// 显示值 = 滑条值 * scale。
        /// 整数阈值传 1.0（滑条值就是显示值）；
        /// 0~1 的小数阈值（最小得分/贪婪度/遮盖度）传 0.01，即滑条 0~100 对应 0.00~1.00。
        /// </param>
        /// <param name="format">显示格式，整数用 "0"，小数用 "0.##"</param>
        private void BindSlider(UITrackBar bar, UITextBox box, double scale, string format)
        {
            // 1) 拖动滑条 → 数值框跟着变
            bar.ValueChanged += (sender, e) =>
            {
                if (syncing)
                {
                    return;
                }

                syncing = true;
                box.Text = (bar.Value * scale).ToString(format, CultureInfo.InvariantCulture);
                syncing = false;
            };

            // 2) 数值框输入 → 滑条跟着动
            box.TextChanged += (sender, e) =>
            {
                if (syncing)
                {
                    return;
                }

                MoveBarToText(bar, box, scale);
            };

            // 3) 启动时以数值框里的初始值为准，把滑条摆到对应位置（不反过来覆盖数值框）
            syncing = true;
            MoveBarToText(bar, box, scale);
            syncing = false;
        }

        /// <summary>
        /// 按数值框里的数字移动滑条；输入为空、只输了半截（如 "0."）或超出量程时不动/截到端点。
        /// </summary>
        private static void MoveBarToText(UITrackBar bar, UITextBox box, double scale)
        {
            double value;
            if (!double.TryParse(box.Text.Trim(), NumberStyles.Float, CultureInfo.InvariantCulture, out value))
            {
                return;
            }

            int index = (int)Math.Round(value / scale, MidpointRounding.AwayFromZero);
            if (index < bar.Minimum)
            {
                index = bar.Minimum;
            }
            else if (index > bar.Maximum)
            {
                index = bar.Maximum;
            }

            bar.Value = index;
        }
        #endregion
    }
}
