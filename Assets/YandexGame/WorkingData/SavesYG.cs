using System.Numerics;

namespace YG
{
    [System.Serializable]
    public class SavesYG
    {
        // "Технические сохранения" для работы плагина (Не удалять)
        public int idSave;
        public bool isFirstSession = true;
        public string language = "ru";
        public bool promptDone;

        public string bitcoins = "0";
        public string _plus_click = "1";
        public string _plus_auto = "0";

        public string slot_buy_count_1 = "0";
        public string slot_buy_count_2 = "0";
        public string slot_buy_count_3 = "0";
        public string slot_buy_count_4 = "0";
        public string slot_buy_count_5 = "0";
        public string slot_buy_count_6 = "0";
        public string slot_buy_count_7 = "0";
        public string slot_buy_count_8 = "0";
        public string slot_buy_count_9 = "0";
        public string slot_buy_count_10 = "0";
        public string slot_buy_count_11 = "0";
        public string slot_buy_count_12 = "0";
        public string slot_buy_count_13 = "0";
        public string slot_buy_count_14 = "0";
        public string slot_buy_count_15 = "0";
        public string slot_buy_count_16 = "0";
        public string slot_buy_count_17 = "0";
        public string slot_buy_count_18 = "0";
        public string slot_buy_count_19 = "0";
        public string slot_buy_count_20 = "0";
        public string slot_buy_count_21 = "0";
        public string slot_buy_count_22 = "0";
        public string slot_buy_count_23 = "0";
        public string slot_buy_count_24 = "0";
        public string slot_buy_count_25 = "0";
        public string slot_buy_count_26 = "0";
        public string slot_buy_count_27 = "0";
        public string slot_buy_count_28 = "0";
        public string slot_buy_count_29 = "0";
        public string slot_buy_count_30 = "0";
        public string slot_buy_count_31 = "0";
        public string slot_buy_count_32 = "0";
        public string slot_buy_count_33 = "0";
        public string slot_buy_count_34 = "0";
        public string slot_buy_count_35 = "0";
        public string slot_buy_count_36 = "0";
        public string slot_buy_count_37 = "0";
        public string slot_buy_count_38 = "0";

        public string slot_price_1 = "10";
        public string slot_price_2 = "25";
        public string slot_price_3 = "500";
        public string slot_price_4 = "2500";
        public string slot_price_6 = "11500";
        public string slot_price_7 = "10000";
        public string slot_price_8 = "1250000";
        public string slot_price_9 = "250000";
        public string slot_price_10 = "1150000";
        public string slot_price_11 = "2550000";
        public string slot_price_12 = "6570000";
        public string slot_price_13 = "14600000";
        public string slot_price_14 = "31000000";
        public string slot_price_15 = "64000000";
        public string slot_price_16 = "135450000";
        public string slot_price_17 = "300000000";
        public string slot_price_18 = "850000000";
        public string slot_price_19 = "1570000000";
        public string slot_price_20 = "8250000000";
        public string slot_price_21 = "25750000000";
        public string slot_price_22 = "78950000000";
        public string slot_price_23 = "355000000000";
        public string slot_price_24 = "1250000000000";
        public string slot_price_25 = "5250000";
        public string slot_price_26 = "25000000";
        public string slot_price_27 = "45000000";
        public string slot_price_28 = "750000000";
        public string slot_price_29 = "1250000000";
        public string slot_price_30 = "2550000000";
        public string slot_price_31 = "4430000000";
        public string slot_price_32 = "8950000000";
        public string slot_price_33 = "23500000000";
        public string slot_price_34 = "63500000000";
        public string slot_price_35 = "975000000000";
        public string slot_price_36 = "1250000000000";
        public string slot_price_37 = "2500000000000";
        public string slot_price_38 = "3750000000000";
        public int current_comp = 1;
        public float currentProgress = 0f;
        public bool isBuyBtnShow = false;
        public int ad_showen = 0;

        public bool is_sounds_changed = false;
        public float sfx = 1;
        public float music = 1;

        // Вы можете выполнить какие то действия при загрузке сохранений
        public SavesYG()
        {
            // Допустим, задать значения по умолчанию для отдельных элементов массива
        }
    }
}
