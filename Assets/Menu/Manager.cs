using UnityEngine;
using YG;
using UnityEngine.UI;
using System.Collections;
using System.Numerics;
using System;

public class Manager : MonoBehaviour
{
    [SerializeField] private Transform lbParent, textClickParent;
    [SerializeField] private Image progressImage, sunImage;
    [SerializeField] private Text counterText, btcPerSecText, progressPercent, currentLevelText, new_level_price, ad_showen_text, rankText;
    [SerializeField] private AudioClip buy_sound, noMoney, newComp, new_level_can_snd, moneyAdded;
    [SerializeField] private AudioSource audio_source;
    [SerializeField] private GameObject adBtn, leaderBoard, new_levelOBJ, _ClickTextPrefab, forbiddenImg;
    [SerializeField] private GameObject[] comps;
    [SerializeField] private Font trFont;
    private string rank1, rank2, rank3, rank4, rank5, rank6, rank7, rank8, rank9, rank10;

    private float targetScale = 1.2f;
    private BigInteger new_level_price_num = 1000;

    public Color blinkColor = Color.red;
    public float blinkDuration = 0.2f;
    private Color originalColor;
    private bool isBlinking = false;

    public BigInteger bitcoins = 0;
    public BigInteger _plus_click = 1;
    public BigInteger _plus_auto = 0;

    public BigInteger slot_buy_count_1 = 0;
    public BigInteger slot_buy_count_2 = 0;
    public BigInteger slot_buy_count_3 = 0;
    public BigInteger slot_buy_count_4 = 0;
    public BigInteger slot_buy_count_5 = 0;
    public BigInteger slot_buy_count_6 = 0;
    public BigInteger slot_buy_count_7 = 0;
    public BigInteger slot_buy_count_8 = 0;
    public BigInteger slot_buy_count_9 = 0;
    public BigInteger slot_buy_count_10 = 0;
    public BigInteger slot_buy_count_11 = 0;
    public BigInteger slot_buy_count_12 = 0;
    public BigInteger slot_buy_count_13 = 0;
    public BigInteger slot_buy_count_14 = 0;
    public BigInteger slot_buy_count_15 = 0;
    public BigInteger slot_buy_count_16 = 0;
    public BigInteger slot_buy_count_17 = 0;
    public BigInteger slot_buy_count_18 = 0;
    public BigInteger slot_buy_count_19 = 0;
    public BigInteger slot_buy_count_20 = 0;
    public BigInteger slot_buy_count_21 = 0;
    public BigInteger slot_buy_count_22 = 0;
    public BigInteger slot_buy_count_23 = 0;
    public BigInteger slot_buy_count_24 = 0;
    public BigInteger slot_buy_count_25 = 0;
    public BigInteger slot_buy_count_26 = 0;
    public BigInteger slot_buy_count_27 = 0;
    public BigInteger slot_buy_count_28 = 0;
    public BigInteger slot_buy_count_29 = 0;
    public BigInteger slot_buy_count_30 = 0;
    public BigInteger slot_buy_count_31 = 0;
    public BigInteger slot_buy_count_32 = 0;
    public BigInteger slot_buy_count_33 = 0;
    public BigInteger slot_buy_count_34 = 0;
    public BigInteger slot_buy_count_35 = 0;
    public BigInteger slot_buy_count_36 = 0;
    public BigInteger slot_buy_count_37 = 0;
    public BigInteger slot_buy_count_38 = 0;

    public BigInteger slot_price_1 = 10;
    public BigInteger slot_price_2 = 25;
    public BigInteger slot_price_3 = 500;
    public BigInteger slot_price_4 = 2500;
    public BigInteger slot_price_6 = 11500;
    public BigInteger slot_price_7 = 10000;
    public BigInteger slot_price_8 = 1250000;
    public BigInteger slot_price_9 = 250000;
    public BigInteger slot_price_10 = 1150000;
    public BigInteger slot_price_11 = 2550000;
    public BigInteger slot_price_12 = 6570000;
    public BigInteger slot_price_13 = 14600000;
    public BigInteger slot_price_14 = 31000000;
    public BigInteger slot_price_15 = 64000000;
    public BigInteger slot_price_16 = 135450000;
    public BigInteger slot_price_17 = 300000000;
    public BigInteger slot_price_18 = 850000000;
    public BigInteger slot_price_19 = 1570000000;
    public BigInteger slot_price_20 = 8250000000;
    public BigInteger slot_price_21 = 25750000000;
    public BigInteger slot_price_22 = 78950000000;
    public BigInteger slot_price_23 = 355000000000;
    public BigInteger slot_price_24 = 1250000000000;
    public BigInteger slot_price_25 = 5250000;
    public BigInteger slot_price_26 = 25000000;
    public BigInteger slot_price_27 = 45000000;
    public BigInteger slot_price_28 = 750000000;
    public BigInteger slot_price_29 = 1250000000;
    public BigInteger slot_price_30 = 2550000000;
    public BigInteger slot_price_31 = 4430000000;
    public BigInteger slot_price_32 = 8950000000;
    public BigInteger slot_price_33 = 23500000000;
    public BigInteger slot_price_34 = 63500000000;
    public BigInteger slot_price_35 = 975000000000;
    public BigInteger slot_price_36 = 1250000000000;
    public BigInteger slot_price_37 = 2500000000000;
    public BigInteger slot_price_38 = 3750000000000;
    private bool allowRotate = false;
    private bool isALreadyBuyShow = false;

    private string num1, num2, num3, num4, num5, num6, num7, num8, num9, num10, num11,
        num12, num13, num14, num15, num16, num17, num18, num19, num20, num21, max_text, max_level_text;
    private void Start()
    {
        if(YandexGame.savesData.isBuyBtnShow == true)
        {
            showBuyLevel();
            isALreadyBuyShow = true;
        }
        originalColor = counterText.color;
        if (YandexGame.SDKEnabled == true)
        {
            ad_showen_text.text = YandexGame.savesData.ad_showen + "/4";

            Update_comp();
            StartCoroutine(Saves_Coroutine());
            StartCoroutine(Auto_BTC_Coroutine());
            ConveringNumbers();
        }
    }

    private void UpdateLang(string str)
    {
        if (str == "ru")
        {
            max_level_text = "Максимальный";

            rank1 = "Новичок в ПК";
            rank2 = "Гик-гений";
            rank3 = "Тех-мастер";
            rank4 = "Кодовый рыцарь";
            rank5 = "Цифровой виртуоз";
            rank6 = "Кибер-знаток";
            rank7 = "Прорицатель данных";
            rank8 = "Системный мудрец";
            rank9 = "Бинарный мастер";
            rank10 = "Компьютерный магистр";

            num1 = " Тыс";
            num2 = " Млн";
            num3 = " Млрд";
            num4 = " Тн";
            num5 = " К";
            num6 = " Кн";
            num7 = " Ст";
            num8 = " Сп";
            num9 = " О";
            num10 = " Н";
            num11 = " Д";
            num12 = " Уд";
            num13 = " Дд";
            num14 = " Тд";
            num15 = " Чад";
            num16 = " Пнд";
            num17 = " Шнд";
            num18 = " Спд";
            num19 = " Внд";
            num20 = " Днд";
            num21 = " Двд";
            max_text = "Максимум";
        }
        else if (str == "en")
        {
            max_level_text = "Maximum";

            rank1 = "PC novice";
            rank2 = "Geek Genius";
            rank3 = "Tech Whiz";
            rank4 = "Code Crusader";
            rank5 = "Digital Virtuoso";
            rank6 = "Cyber Savant";
            rank7 = "Data Diviner";
            rank8 = "System Sage";
            rank9 = "Binary Maestro";
            rank10 = "Computer Maestro";

            num1 = " K";
            num2 = " M";
            num3 = " B";
            num4 = " T";
            num5 = " Q";
            num6 = " Qn";
            num7 = " Sx";
            num8 = " Sp";
            num9 = " Oc";
            num10 = " No";
            num11 = " Dc";
            num12 = " Ud";
            num13 = " Dd";
            num14 = " Td";
            num15 = " Qad";
            num16 = " Qnd";
            num17 = " Sxd";
            num18 = " Spd";
            num19 = " Ocd";
            num20 = " Nvd";
            num21 = " Vg";
            max_text = "Maximum";
        }
        else if (str == "tr")
        {
            max_level_text = "Maksimum";
            btcPerSecText.font = trFont;
            currentLevelText.font = trFont;
            new_level_price.font = trFont;
            counterText.font = trFont;

            rank1 = "PC acemisi";
            rank2 = "Geek Dehası";
            rank3 = "Tekno Deha";
            rank4 = "Kod Haçlısı";
            rank5 = "Dijital Uzman";
            rank6 = "Siber Dahi";
            rank7 = "Veri Kehaneti";
            rank8 = "Sistem Bilgesi";
            rank9 = "İkili Usta";
            rank10 = "Bilgisayar Usta";

            num1 = " K";
            num2 = " M";
            num3 = " B";
            num4 = " T";
            num5 = " Q";
            num6 = " Qn";
            num7 = " Sx";
            num8 = " Sp";
            num9 = " Oc";
            num10 = " No";
            num11 = " Dc";
            num12 = " Ud";
            num13 = " Dd";
            num14 = " Td";
            num15 = " Qad";
            num16 = " Qnd";
            num17 = " Sxd";
            num18 = " Spd";
            num19 = " Ocd";
            num20 = " Nvd";
            num21 = " Vg";
            max_text = "Maksimum";
        }
    }

    private void Update_comp()
    {
        switch (YandexGame.savesData.current_comp)
        {
            case 1:
                foreach(GameObject obj in comps)
                {
                    obj.SetActive(false);
                }
                comps[0].SetActive(true);
                progressImage.fillAmount = YandexGame.savesData.currentProgress / 100f;
                progressPercent.text = Mathf.RoundToInt(YandexGame.savesData.currentProgress) + "%";
                break;
            case 2:
                foreach (GameObject obj in comps)
                {
                    obj.SetActive(false);
                }
                comps[1].SetActive(true);
                progressImage.fillAmount = YandexGame.savesData.currentProgress / 100f;
                progressPercent.text = Mathf.RoundToInt(YandexGame.savesData.currentProgress) + "%";
                break;
            case 3:
                foreach (GameObject obj in comps)
                {
                    obj.SetActive(false);
                }
                comps[2].SetActive(true);
                progressImage.fillAmount = YandexGame.savesData.currentProgress / 100f;
                progressPercent.text = Mathf.RoundToInt(YandexGame.savesData.currentProgress) + "%";
                break;
            case 4:
                foreach (GameObject obj in comps)
                {
                    obj.SetActive(false);
                }
                comps[3].SetActive(true);
                progressImage.fillAmount = YandexGame.savesData.currentProgress / 100f;
                progressPercent.text = Mathf.RoundToInt(YandexGame.savesData.currentProgress) + "%";
                break;
            case 5:
                foreach (GameObject obj in comps)
                {
                    obj.SetActive(false);
                }
                comps[4].SetActive(true);
                progressImage.fillAmount = YandexGame.savesData.currentProgress / 100f;
                progressPercent.text = Mathf.RoundToInt(YandexGame.savesData.currentProgress) + "%";
                break;
            case 6:
                foreach (GameObject obj in comps)
                {
                    obj.SetActive(false);
                }
                comps[5].SetActive(true);
                progressImage.fillAmount = YandexGame.savesData.currentProgress / 100f;
                progressPercent.text = Mathf.RoundToInt(YandexGame.savesData.currentProgress) + "%";
                break;
            case 7:
                foreach (GameObject obj in comps)
                {
                    obj.SetActive(false);
                }
                comps[6].SetActive(true);
                progressImage.fillAmount = YandexGame.savesData.currentProgress / 100f;
                progressPercent.text = Mathf.RoundToInt(YandexGame.savesData.currentProgress) + "%";
                break;
            case 8:
                foreach (GameObject obj in comps)
                {
                    obj.SetActive(false);
                }
                comps[7].SetActive(true);
                progressImage.fillAmount = YandexGame.savesData.currentProgress / 100f;
                progressPercent.text = Mathf.RoundToInt(YandexGame.savesData.currentProgress) + "%";
                break;
            case 9:
                foreach (GameObject obj in comps)
                {
                    obj.SetActive(false);
                }
                comps[8].SetActive(true);
                progressImage.fillAmount = YandexGame.savesData.currentProgress / 100f;
                progressPercent.text = Mathf.RoundToInt(YandexGame.savesData.currentProgress) + "%";
                break;
            case 10:
                foreach (GameObject obj in comps)
                {
                    obj.SetActive(false);
                }
                comps[9].SetActive(true);
                progressImage.fillAmount = YandexGame.savesData.currentProgress / 100f;
                progressPercent.text = Mathf.RoundToInt(YandexGame.savesData.currentProgress) + "%";
                break;
            case 11:
                foreach (GameObject obj in comps)
                {
                    obj.SetActive(false);
                }
                comps[10].SetActive(true);
                progressImage.fillAmount = YandexGame.savesData.currentProgress / 100f;
                progressPercent.text = Mathf.RoundToInt(YandexGame.savesData.currentProgress) + "%";
                break;
            case 12:
                foreach (GameObject obj in comps)
                {
                    obj.SetActive(false);
                }
                comps[11].SetActive(true);
                progressImage.fillAmount = YandexGame.savesData.currentProgress / 100f;
                progressPercent.text = Mathf.RoundToInt(YandexGame.savesData.currentProgress) + "%";
                break;
            case 13:
                foreach (GameObject obj in comps)
                {
                    obj.SetActive(false);
                }
                comps[12].SetActive(true);
                progressImage.fillAmount = YandexGame.savesData.currentProgress / 100f;
                progressPercent.text = Mathf.RoundToInt(YandexGame.savesData.currentProgress) + "%";
                break;
            case 14:
                foreach (GameObject obj in comps)
                {
                    obj.SetActive(false);
                }
                comps[13].SetActive(true);
                progressImage.fillAmount = YandexGame.savesData.currentProgress / 100f;
                progressPercent.text = Mathf.RoundToInt(YandexGame.savesData.currentProgress) + "%";
                break;
            case 15:
                foreach (GameObject obj in comps)
                {
                    obj.SetActive(false);
                }
                comps[14].SetActive(true);
                progressPercent.text = max_level_text;
                progressImage.fillAmount = 100f;
                break;
        }
    }

    private void Update()
    {
        if(allowRotate == true)
        {
            sunImage.transform.Rotate(UnityEngine.Vector3.forward * 100 * Time.deltaTime);
        }
        if (bitcoins < new_level_price_num)
        {
            new_level_price.color = Color.red;
        }
        else
        {
            new_level_price.color = Color.white;
        }

        if (isALreadyBuyShow == true)
        {
            new_level_price.text = FormatNumberShort(new_level_price_num);
        }
        if (YandexGame.SDKEnabled == true)
        {
            if(YandexGame.savesData.ad_showen == 4)
            {
                forbiddenImg.SetActive(true);
            }
            if (YandexGame.lang == "ru")
            {
                currentLevelText.text = "Компьютер Уровня " + YandexGame.savesData.current_comp;
                btcPerSecText.text = FormatNumberShort(_plus_auto).ToString() + " БТК/сек";
            }
            else if (YandexGame.lang == "en")
            {
                currentLevelText.text = "Computer Level " + YandexGame.savesData.current_comp;
                btcPerSecText.text = FormatNumberShort(_plus_auto).ToString() + " BTC/sec";
            }
            else if (YandexGame.lang == "tr")
            {
                currentLevelText.text = "Bilgisayar Seviye " + YandexGame.savesData.current_comp;
                btcPerSecText.text = FormatNumberShort(_plus_auto).ToString() + " BTC/sn";
            }

            FormatNumber(bitcoins);
            ShowAdButton();
            UpdateLang(YandexGame.lang);
            UpdateRank();
        }
    }
    private void OnEnable()
    {
        YandexGame.RewardVideoEvent += Rewarded;
    }
    private void OnDisable()
    {
        YandexGame.RewardVideoEvent -= Rewarded;
    }
    private void ShowAdButton()
    {
        if (bitcoins > 0)
        {
            adBtn.SetActive(true);
        }
        else
        {
            adBtn.SetActive(false);
        }
    }
    public void UpdateTextCounter()
    {
        bitcoins += _plus_click;

        // Получаем позицию курсора
        UnityEngine.Vector3 cursorPosition = Input.mousePosition;
        cursorPosition.z = 10; // Меняем Z-координату для правильного отображения в двухмерном пространстве

        // Преобразуем экранные координаты в мировые
        UnityEngine.Vector3 worldPosition = Camera.main.ScreenToWorldPoint(cursorPosition);

        // Создаем экземпляр _ClickTextPrefab в нужной позиции
        GameObject instantiatedObject = Instantiate(_ClickTextPrefab, worldPosition, UnityEngine.Quaternion.identity, textClickParent);

        Text click_num_fade = instantiatedObject.transform.Find("number").GetComponent<Text>();
        click_num_fade.text = "+" + FormatNumberShort(_plus_click);
    }

    public void UpdateTextCounterAuto()
    {
        bitcoins += _plus_auto;
    }
    private IEnumerator Auto_BTC_Coroutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            UpdateTextCounterAuto();
        }
    }
    private IEnumerator Saves_Coroutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(5);
            ConveringNumbersBack();
            YandexGame.SaveProgress();
        }
    }
    public void BuySlot_1()
    {
        if (TimerBeforeAdsYG.allowClicks == true)
        {
            if (bitcoins >= slot_price_1)
            {
                bitcoins -= slot_price_1;
                _plus_click += 1;
                audio_source.PlayOneShot(buy_sound);
                slot_buy_count_1 += 1;

                BigInteger bigIntValue = (slot_price_1);
                BigInteger multipliedValue = BigInteger.Multiply(bigIntValue, 110);
                BigInteger roundedValue = BigInteger.Divide(multipliedValue, 100);
                slot_price_1 = roundedValue;
                UpdateRank();
            }
            else
            {
                audio_source.PlayOneShot(noMoney);
                StartBlinkingNoMoney();
            }
        }
    }
    public void BuySlot_2()
    {
        if (TimerBeforeAdsYG.allowClicks == true)
        {
            if (bitcoins >= slot_price_2)
            {
                bitcoins -= slot_price_2;
                _plus_auto += 1;
                audio_source.PlayOneShot(buy_sound);
                slot_buy_count_2 += 1;

                BigInteger bigIntValue = (slot_price_2);
                BigInteger multipliedValue = BigInteger.Multiply(bigIntValue, 110);
                BigInteger roundedValue = BigInteger.Divide(multipliedValue, 100);
                slot_price_2 = roundedValue;
                UpdateRank();
            }
            else
            {
                audio_source.PlayOneShot(noMoney);
                StartBlinkingNoMoney();
            }
        }
    }
    public void BuySlot_3()
    {
        if (TimerBeforeAdsYG.allowClicks == true)
        {
            if (bitcoins >= slot_price_3)
            {
                bitcoins -= slot_price_3;
                _plus_click += 10;
                audio_source.PlayOneShot(buy_sound);
                slot_buy_count_3 += 1;

                BigInteger bigIntValue = (slot_price_3);
                BigInteger multipliedValue = BigInteger.Multiply(bigIntValue, 110);
                BigInteger roundedValue = BigInteger.Divide(multipliedValue, 100);
                slot_price_3 = roundedValue;
                UpdateRank();
            }
            else
            {
                audio_source.PlayOneShot(noMoney);
                StartBlinkingNoMoney();
            }
        }
    }
    public void BuySlot_4()
    {
        if (TimerBeforeAdsYG.allowClicks == true)
        {
            if (bitcoins >= slot_price_4)
            {
                bitcoins -= slot_price_4;
                _plus_auto += 5;
                audio_source.PlayOneShot(buy_sound);
                slot_buy_count_4 += 1;

                BigInteger bigIntValue = (slot_price_4);
                BigInteger multipliedValue = BigInteger.Multiply(bigIntValue, 110);
                BigInteger roundedValue = BigInteger.Divide(multipliedValue, 100);
                slot_price_4 = roundedValue;
                UpdateRank();
            }
            else
            {
                audio_source.PlayOneShot(noMoney);
                StartBlinkingNoMoney();
            }
        }
    }
    public void BuySlot_5()
    {
        if (TimerBeforeAdsYG.allowClicks == true)
        {
            OpenRewardAd2(2);
        }
    }
    public void BuySlot_6()
    {
        if (TimerBeforeAdsYG.allowClicks == true)
        {
            if (bitcoins >= slot_price_6)
            {
                bitcoins -= slot_price_6;
                _plus_auto += 60;
                audio_source.PlayOneShot(buy_sound);
                slot_buy_count_6 += 1;

                BigInteger bigIntValue = (slot_price_6);
                BigInteger multipliedValue = BigInteger.Multiply(bigIntValue, 110);
                BigInteger roundedValue = BigInteger.Divide(multipliedValue, 100);
                slot_price_6 = roundedValue;
                UpdateRank();
            }
            else
            {
                audio_source.PlayOneShot(noMoney);
                StartBlinkingNoMoney();
            }
        }
    }
    public void BuySlot_7()
    {
        if (TimerBeforeAdsYG.allowClicks == true)
        {
            if (bitcoins >= slot_price_7)
            {
                bitcoins -= slot_price_7;
                _plus_click += 100;
                audio_source.PlayOneShot(buy_sound);
                slot_buy_count_7 += 1;

                BigInteger bigIntValue = (slot_price_7);
                BigInteger multipliedValue = BigInteger.Multiply(bigIntValue, 110);
                BigInteger roundedValue = BigInteger.Divide(multipliedValue, 100);
                slot_price_7 = roundedValue;
                UpdateRank();
            }
            else
            {
                audio_source.PlayOneShot(noMoney);
                StartBlinkingNoMoney();
            }
        }
    }
    public void BuySlot_8()
    {
        if (TimerBeforeAdsYG.allowClicks == true)
        {
            if (bitcoins >= slot_price_8)
            {
                bitcoins -= slot_price_8;
                _plus_auto += 210;
                audio_source.PlayOneShot(buy_sound);
                slot_buy_count_8 += 1;

                BigInteger bigIntValue = (slot_price_8);
                BigInteger multipliedValue = BigInteger.Multiply(bigIntValue, 110);
                BigInteger roundedValue = BigInteger.Divide(multipliedValue, 100);
                slot_price_8 = roundedValue;
                UpdateRank();
            }
            else
            {
                audio_source.PlayOneShot(noMoney);
                StartBlinkingNoMoney();
            }
        }
    }
    public void BuySlot_9()
    {
        if (TimerBeforeAdsYG.allowClicks == true)
        {
            if (bitcoins >= slot_price_9)
            {
                bitcoins -= slot_price_9;
                audio_source.PlayOneShot(buy_sound);
                _plus_click += 250;
                slot_buy_count_9 += 1;

                BigInteger bigIntValue = (slot_price_9);
                BigInteger multipliedValue = BigInteger.Multiply(bigIntValue, 110);
                BigInteger roundedValue = BigInteger.Divide(multipliedValue, 100);
                slot_price_9 = roundedValue;
                UpdateRank();
            }
            else
            {
                audio_source.PlayOneShot(noMoney);
                StartBlinkingNoMoney();
            }
        }
    }
    public void BuySlot_10()
    {
        if (TimerBeforeAdsYG.allowClicks == true)
        {
            if (bitcoins >= slot_price_10)
            {
                bitcoins -= slot_price_10;
                audio_source.PlayOneShot(buy_sound);
                _plus_click += 1000;
                slot_buy_count_10 += 1;

                BigInteger bigIntValue = (slot_price_10);
                BigInteger multipliedValue = BigInteger.Multiply(bigIntValue, 110);
                BigInteger roundedValue = BigInteger.Divide(multipliedValue, 100);
                slot_price_10 = roundedValue;
                UpdateRank();
            }
            else
            {
                audio_source.PlayOneShot(noMoney);
                StartBlinkingNoMoney();
            }
        }
    }
    public void BuySlot_11()
    {
        if (TimerBeforeAdsYG.allowClicks == true)
        {
            if (bitcoins >= slot_price_11)
            {
                bitcoins -= slot_price_11;
                audio_source.PlayOneShot(buy_sound);
                _plus_click += 2500;
                slot_buy_count_11 += 1;

                BigInteger bigIntValue = (slot_price_11);
                BigInteger multipliedValue = BigInteger.Multiply(bigIntValue, 110);
                BigInteger roundedValue = BigInteger.Divide(multipliedValue, 100);
                slot_price_11 = roundedValue;
                UpdateRank();
            }
            else
            {
                audio_source.PlayOneShot(noMoney);
                StartBlinkingNoMoney();
            }
        }
    }
    public void BuySlot_12()
    {
        if (TimerBeforeAdsYG.allowClicks == true)
        {
            if (bitcoins >= slot_price_12)
            {
                bitcoins -= slot_price_12;
                audio_source.PlayOneShot(buy_sound);
                _plus_click += 5000;
                slot_buy_count_12 += 1;

                BigInteger bigIntValue = (slot_price_12);
                BigInteger multipliedValue = BigInteger.Multiply(bigIntValue, 110);
                BigInteger roundedValue = BigInteger.Divide(multipliedValue, 100);
                slot_price_12 = roundedValue;
                UpdateRank();
            }
            else
            {
                audio_source.PlayOneShot(noMoney);
                StartBlinkingNoMoney();
            }
        }
    }
    public void BuySlot_13()
    {
        if (TimerBeforeAdsYG.allowClicks == true)
        {
            if (bitcoins >= slot_price_13)
            {
                bitcoins -= slot_price_13;
                audio_source.PlayOneShot(buy_sound);
                _plus_click += 12500;
                slot_buy_count_13 += 1;

                BigInteger bigIntValue = (slot_price_13);
                BigInteger multipliedValue = BigInteger.Multiply(bigIntValue, 110);
                BigInteger roundedValue = BigInteger.Divide(multipliedValue, 100);
                slot_price_13 = roundedValue;
                UpdateRank();
            }
            else
            {
                audio_source.PlayOneShot(noMoney);
                StartBlinkingNoMoney();
            }
        }
    }
    public void BuySlot_14()
    {
        if (TimerBeforeAdsYG.allowClicks == true)
        {
            if (bitcoins >= slot_price_14)
            {
                bitcoins -= slot_price_14;
                audio_source.PlayOneShot(buy_sound);
                _plus_click += 34500;
                slot_buy_count_14 += 1;

                BigInteger bigIntValue = (slot_price_14);
                BigInteger multipliedValue = BigInteger.Multiply(bigIntValue, 110);
                BigInteger roundedValue = BigInteger.Divide(multipliedValue, 100);
                slot_price_14 = roundedValue;
                UpdateRank();
            }
            else
            {
                audio_source.PlayOneShot(noMoney);
                StartBlinkingNoMoney();
            }
        }
    }
    public void BuySlot_15()
    {
        if (TimerBeforeAdsYG.allowClicks == true)
        {
            if (bitcoins >= slot_price_15)
            {
                bitcoins -= slot_price_15;
                audio_source.PlayOneShot(buy_sound);
                _plus_click += 82750;
                slot_buy_count_15 += 1;

                BigInteger bigIntValue = (slot_price_15);
                BigInteger multipliedValue = BigInteger.Multiply(bigIntValue, 110);
                BigInteger roundedValue = BigInteger.Divide(multipliedValue, 100);
                slot_price_15 = roundedValue;
                UpdateRank();
            }
            else
            {
                audio_source.PlayOneShot(noMoney);
                StartBlinkingNoMoney();
            }
        }
    }
    public void BuySlot_16()
    {
        if (TimerBeforeAdsYG.allowClicks == true)
        {
            if (bitcoins >= slot_price_16)
            {
                bitcoins -= slot_price_16;
                audio_source.PlayOneShot(buy_sound);
                _plus_click += 255000;
                slot_buy_count_16 += 1;

                BigInteger bigIntValue = (slot_price_16);
                BigInteger multipliedValue = BigInteger.Multiply(bigIntValue, 110);
                BigInteger roundedValue = BigInteger.Divide(multipliedValue, 100);
                slot_price_16 = roundedValue;
                UpdateRank();
            }
            else
            {
                audio_source.PlayOneShot(noMoney);
                StartBlinkingNoMoney();
            }
        }
    }
    public void BuySlot_17()
    {
        if (TimerBeforeAdsYG.allowClicks == true)
        {
            if (bitcoins >= slot_price_17)
            {
                bitcoins -= slot_price_17;
                audio_source.PlayOneShot(buy_sound);
                _plus_click += 605000;
                slot_buy_count_17 += 1;

                BigInteger bigIntValue = (slot_price_17);
                BigInteger multipliedValue = BigInteger.Multiply(bigIntValue, 110);
                BigInteger roundedValue = BigInteger.Divide(multipliedValue, 100);
                slot_price_17 = roundedValue;
                UpdateRank();
            }
            else
            {
                audio_source.PlayOneShot(noMoney);
                StartBlinkingNoMoney();
            }
        }
    }
    public void BuySlot_18()
    {
        if (TimerBeforeAdsYG.allowClicks == true)
        {
            if (bitcoins >= slot_price_18)
            {
                bitcoins -= slot_price_18;
                audio_source.PlayOneShot(buy_sound);
                _plus_click += 1000000;
                slot_buy_count_18 += 1;

                BigInteger bigIntValue = (slot_price_18);
                BigInteger multipliedValue = BigInteger.Multiply(bigIntValue, 110);
                BigInteger roundedValue = BigInteger.Divide(multipliedValue, 100);
                slot_price_18 = roundedValue;
                UpdateRank();
            }
            else
            {
                audio_source.PlayOneShot(noMoney);
                StartBlinkingNoMoney();
            }
        }
    }
    public void BuySlot_19()
    {
        if (TimerBeforeAdsYG.allowClicks == true)
        {
            if (bitcoins >= slot_price_19)
            {
                bitcoins -= slot_price_19;
                audio_source.PlayOneShot(buy_sound);
                _plus_click += 5500000;
                slot_buy_count_19 += 1;

                BigInteger bigIntValue = (slot_price_19);
                BigInteger multipliedValue = BigInteger.Multiply(bigIntValue, 110);
                BigInteger roundedValue = BigInteger.Divide(multipliedValue, 100);
                slot_price_19 = roundedValue;
                UpdateRank();
            }
            else
            {
                audio_source.PlayOneShot(noMoney);
                StartBlinkingNoMoney();
            }
        }
    }
    public void BuySlot_20()
    {
        if (TimerBeforeAdsYG.allowClicks == true)
        {
            if (bitcoins >= slot_price_20)
            {
                bitcoins -= slot_price_20;
                audio_source.PlayOneShot(buy_sound);
                _plus_click += 17500000;
                slot_buy_count_20 += 1;

                BigInteger bigIntValue = (slot_price_20);
                BigInteger multipliedValue = BigInteger.Multiply(bigIntValue, 110);
                BigInteger roundedValue = BigInteger.Divide(multipliedValue, 100);
                slot_price_20 = roundedValue;
                UpdateRank();
            }
            else
            {
                audio_source.PlayOneShot(noMoney);
                StartBlinkingNoMoney();
            }
        }
    }
    public void BuySlot_21()
    {
        if (TimerBeforeAdsYG.allowClicks == true)
        {
            if (bitcoins >= slot_price_21)
            {
                bitcoins -= slot_price_21;
                audio_source.PlayOneShot(buy_sound);
                _plus_click += 122500000;
                slot_buy_count_21 += 1;

                BigInteger bigIntValue = (slot_price_21);
                BigInteger multipliedValue = BigInteger.Multiply(bigIntValue, 110);
                BigInteger roundedValue = BigInteger.Divide(multipliedValue, 100);
                slot_price_21 = roundedValue;
                UpdateRank();
            }
            else
            {
                audio_source.PlayOneShot(noMoney);
                StartBlinkingNoMoney();
            }
        }
    }
    public void BuySlot_22()
    {
        if (TimerBeforeAdsYG.allowClicks == true)
        {
            if (bitcoins >= slot_price_22)
            {
                bitcoins -= slot_price_22;
                audio_source.PlayOneShot(buy_sound);
                _plus_click += 700000000;
                slot_buy_count_22 += 1;

                BigInteger bigIntValue = (slot_price_22);
                BigInteger multipliedValue = BigInteger.Multiply(bigIntValue, 110);
                BigInteger roundedValue = BigInteger.Divide(multipliedValue, 100);
                slot_price_22 = roundedValue;
                UpdateRank();
            }
            else
            {
                audio_source.PlayOneShot(noMoney);
                StartBlinkingNoMoney();
            }
        }
    }
    public void BuySlot_23()
    {
        if (TimerBeforeAdsYG.allowClicks == true)
        {
            if (bitcoins >= slot_price_23)
            {
                bitcoins -= slot_price_23;
                audio_source.PlayOneShot(buy_sound);
                _plus_click += 1000000000;
                slot_buy_count_23 += 1;

                BigInteger bigIntValue = (slot_price_23);
                BigInteger multipliedValue = BigInteger.Multiply(bigIntValue, 110);
                BigInteger roundedValue = BigInteger.Divide(multipliedValue, 100);
                slot_price_23 = roundedValue;
                UpdateRank();
            }
            else
            {
                audio_source.PlayOneShot(noMoney);
                StartBlinkingNoMoney();
            }
        }
    }
    public void BuySlot_24()
    {
        if (TimerBeforeAdsYG.allowClicks == true)
        {
            if (bitcoins >= slot_price_24)
            {
                bitcoins -= slot_price_24;
                audio_source.PlayOneShot(buy_sound);
                _plus_click += 15000000000;
                slot_buy_count_24 += 1;

                BigInteger bigIntValue = (slot_price_24);
                BigInteger multipliedValue = BigInteger.Multiply(bigIntValue, 110);
                BigInteger roundedValue = BigInteger.Divide(multipliedValue, 100);
                slot_price_24 = roundedValue;
                UpdateRank();
            }
            else
            {
                audio_source.PlayOneShot(noMoney);
                StartBlinkingNoMoney();
            }
        }
    }
    public void BuySlot_25()
    {
        if (TimerBeforeAdsYG.allowClicks == true)
        {
            if (bitcoins >= slot_price_25)
            {
                bitcoins -= slot_price_25;
                audio_source.PlayOneShot(buy_sound);
                _plus_auto += 750;
                slot_buy_count_25 += 1;

                BigInteger bigIntValue = (slot_price_25);
                BigInteger multipliedValue = BigInteger.Multiply(bigIntValue, 110);
                BigInteger roundedValue = BigInteger.Divide(multipliedValue, 100);
                slot_price_25 = roundedValue;
                UpdateRank();
            }
            else
            {
                audio_source.PlayOneShot(noMoney);
                StartBlinkingNoMoney();
            }
        }
    }
    public void BuySlot_26()
    {
        if (TimerBeforeAdsYG.allowClicks == true)
        {
            if (bitcoins >= slot_price_26)
            {
                bitcoins -= slot_price_26;
                audio_source.PlayOneShot(buy_sound);
                _plus_auto += 1350;
                slot_buy_count_26 += 1;

                BigInteger bigIntValue = (slot_price_26);
                BigInteger multipliedValue = BigInteger.Multiply(bigIntValue, 110);
                BigInteger roundedValue = BigInteger.Divide(multipliedValue, 100);
                slot_price_26 = roundedValue;
                UpdateRank();
            }
            else
            {
                audio_source.PlayOneShot(noMoney);
                StartBlinkingNoMoney();
            }
        }
    }
    public void BuySlot_27()
    {
        if (TimerBeforeAdsYG.allowClicks == true)
        {
            if (bitcoins >= slot_price_27)
            {
                bitcoins -= slot_price_27;
                audio_source.PlayOneShot(buy_sound);
                _plus_auto += 5500;
                slot_buy_count_27 += 1;

                BigInteger bigIntValue = (slot_price_27);
                BigInteger multipliedValue = BigInteger.Multiply(bigIntValue, 110);
                BigInteger roundedValue = BigInteger.Divide(multipliedValue, 100);
                slot_price_27 = roundedValue;
                UpdateRank();
            }
            else
            {
                audio_source.PlayOneShot(noMoney);
                StartBlinkingNoMoney();
            }
        }
    }
    public void BuySlot_28()
    {
        if (TimerBeforeAdsYG.allowClicks == true)
        {
            if (bitcoins >= slot_price_28)
            {
                bitcoins -= slot_price_28;
                _plus_auto += 15000;
                audio_source.PlayOneShot(buy_sound);
                slot_buy_count_28 += 1;

                BigInteger bigIntValue = (slot_price_28);
                BigInteger multipliedValue = BigInteger.Multiply(bigIntValue, 110);
                BigInteger roundedValue = BigInteger.Divide(multipliedValue, 100);
                slot_price_28 = roundedValue;
                UpdateRank();
            }
            else
            {
                audio_source.PlayOneShot(noMoney);
                StartBlinkingNoMoney();
            }
        }
    }
    public void BuySlot_29()
    {
        if (TimerBeforeAdsYG.allowClicks == true)
        {
            if (bitcoins >= slot_price_29)
            {
                bitcoins -= slot_price_29;
                audio_source.PlayOneShot(buy_sound);
                _plus_auto += 35000;
                slot_buy_count_29 += 1;

                BigInteger bigIntValue = (slot_price_29);
                BigInteger multipliedValue = BigInteger.Multiply(bigIntValue, 110);
                BigInteger roundedValue = BigInteger.Divide(multipliedValue, 100);
                slot_price_29 = roundedValue;
                UpdateRank();
            }
            else
            {
                audio_source.PlayOneShot(noMoney);
                StartBlinkingNoMoney();
            }
        }
    }
    public void BuySlot_30()
    {
        if (TimerBeforeAdsYG.allowClicks == true)
        {
            if (bitcoins >= slot_price_30)
            {
                bitcoins -= slot_price_30;
                audio_source.PlayOneShot(buy_sound);
                _plus_auto += 85000;
                slot_buy_count_30 += 1;

                BigInteger bigIntValue = (slot_price_30);
                BigInteger multipliedValue = BigInteger.Multiply(bigIntValue, 110);
                BigInteger roundedValue = BigInteger.Divide(multipliedValue, 100);
                slot_price_30 = roundedValue;
                UpdateRank();
            }
            else
            {
                audio_source.PlayOneShot(noMoney);
                StartBlinkingNoMoney();
            }
        }
    }
    public void BuySlot_31()
    {
        if (TimerBeforeAdsYG.allowClicks == true)
        {
            if (bitcoins >= slot_price_31)
            {
                bitcoins -= slot_price_31;
                audio_source.PlayOneShot(buy_sound);
                _plus_auto += 192500;
                slot_buy_count_31 += 1;

                BigInteger bigIntValue = (slot_price_31);
                BigInteger multipliedValue = BigInteger.Multiply(bigIntValue, 110);
                BigInteger roundedValue = BigInteger.Divide(multipliedValue, 100);
                slot_price_31 = roundedValue;
                UpdateRank();
            }
            else
            {
                audio_source.PlayOneShot(noMoney);
                StartBlinkingNoMoney();
            }
        }
    }
    public void BuySlot_32()
    {
        if (TimerBeforeAdsYG.allowClicks == true)
        {
            if (bitcoins >= slot_price_32)
            {
                bitcoins -= slot_price_32;
                audio_source.PlayOneShot(buy_sound);
                _plus_auto += 550000;
                slot_buy_count_32 += 1;

                BigInteger bigIntValue = (slot_price_32);
                BigInteger multipliedValue = BigInteger.Multiply(bigIntValue, 110);
                BigInteger roundedValue = BigInteger.Divide(multipliedValue, 100);
                slot_price_32 = roundedValue;
                UpdateRank();
            }
            else
            {
                audio_source.PlayOneShot(noMoney);
                StartBlinkingNoMoney();
            }
        }
    }
    public void BuySlot_33()
    {
        if (TimerBeforeAdsYG.allowClicks == true)
        {
            if (bitcoins >= slot_price_33)
            {
                bitcoins -= slot_price_33;
                audio_source.PlayOneShot(buy_sound);
                _plus_auto += 1250000;
                slot_buy_count_33 += 1;

                BigInteger bigIntValue = (slot_price_33);
                BigInteger multipliedValue = BigInteger.Multiply(bigIntValue, 110);
                BigInteger roundedValue = BigInteger.Divide(multipliedValue, 100);
                slot_price_33 = roundedValue;
                UpdateRank();
            }
            else
            {
                audio_source.PlayOneShot(noMoney);
                StartBlinkingNoMoney();
            }
        }
    }
    public void BuySlot_34()
    {
        if (TimerBeforeAdsYG.allowClicks == true)
        {
            if (bitcoins >= slot_price_34)
            {
                bitcoins -= slot_price_34;
                audio_source.PlayOneShot(buy_sound);
                _plus_auto += 3500000;
                slot_buy_count_34 += 1;

                BigInteger bigIntValue = (slot_price_34);
                BigInteger multipliedValue = BigInteger.Multiply(bigIntValue, 110);
                BigInteger roundedValue = BigInteger.Divide(multipliedValue, 100);
                slot_price_34 = roundedValue;
                UpdateRank();
            }
            else
            {
                audio_source.PlayOneShot(noMoney);
                StartBlinkingNoMoney();
            }
        }
    }
    public void BuySlot_35()
    {
        if (TimerBeforeAdsYG.allowClicks == true)
        {
            if (bitcoins >= slot_price_35)
            {
                bitcoins -= slot_price_35;
                audio_source.PlayOneShot(buy_sound);
                _plus_auto += 10000000;
                slot_buy_count_35 += 1;

                BigInteger bigIntValue = (slot_price_35);
                BigInteger multipliedValue = BigInteger.Multiply(bigIntValue, 110);
                BigInteger roundedValue = BigInteger.Divide(multipliedValue, 100);
                slot_price_35 = roundedValue;
                UpdateRank();
            }
            else
            {
                audio_source.PlayOneShot(noMoney);
                StartBlinkingNoMoney();
            }
        }
    }
    public void BuySlot_36()
    {
        if (TimerBeforeAdsYG.allowClicks == true)
        {
            if (bitcoins >= slot_price_36)
            {
                bitcoins -= slot_price_36;
                audio_source.PlayOneShot(buy_sound);
                _plus_auto += 30000000;
                slot_buy_count_36 += 1;

                BigInteger bigIntValue = (slot_price_36);
                BigInteger multipliedValue = BigInteger.Multiply(bigIntValue, 110);
                BigInteger roundedValue = BigInteger.Divide(multipliedValue, 100);
                slot_price_36 = roundedValue;
                UpdateRank();
            }
            else
            {
                audio_source.PlayOneShot(noMoney);
                StartBlinkingNoMoney();
            }
        }
    }
    public void BuySlot_37()
    {
        if (TimerBeforeAdsYG.allowClicks == true)
        {
            if (bitcoins >= slot_price_37)
            {
                bitcoins -= slot_price_37;
                audio_source.PlayOneShot(buy_sound);
                _plus_auto += 150000000;
                slot_buy_count_37 += 1;

                BigInteger bigIntValue = (slot_price_37);
                BigInteger multipliedValue = BigInteger.Multiply(bigIntValue, 110);
                BigInteger roundedValue = BigInteger.Divide(multipliedValue, 100);
                slot_price_37 = roundedValue;
                UpdateRank();
            }
            else
            {
                audio_source.PlayOneShot(noMoney);
                StartBlinkingNoMoney();
            }
        }
    }
    public void BuySlot_38()
    {
        if (TimerBeforeAdsYG.allowClicks == true)
        {
            if (bitcoins >= slot_price_38)
            {
                bitcoins -= slot_price_38;
                _plus_auto += 675000000;
                audio_source.PlayOneShot(buy_sound);
                slot_buy_count_38 += 1;

                BigInteger bigIntValue = (slot_price_38);
                BigInteger multipliedValue = BigInteger.Multiply(bigIntValue, 110);
                BigInteger roundedValue = BigInteger.Divide(multipliedValue, 100);
                slot_price_38 = roundedValue;
                UpdateRank();
            }
            else
            {
                audio_source.PlayOneShot(noMoney);
                StartBlinkingNoMoney();
            }
        }
    }
    public void StartBlinkingNoMoney()
    {
        if (!isBlinking)
        {
            StartCoroutine(BlinkText());
        }
    }
    IEnumerator BlinkText()
    {
        isBlinking = true;
        float time = 0f;

        while (time < blinkDuration)
        {
            counterText.color = (counterText.color == originalColor) ? blinkColor : originalColor;
            time += Time.deltaTime;
            yield return null;
        }

        counterText.color = originalColor;
        isBlinking = false;
    }
    void Rewarded(int id)
    {
        if (id == 1)
        {
            if(YandexGame.savesData.ad_showen != 4)
            {
                audio_source.PlayOneShot(moneyAdded);
                YandexGame.savesData.ad_showen += 1;
                ad_showen_text.text = YandexGame.savesData.ad_showen + "/4";
                bitcoins *= 2;
                YandexGame.SaveProgress();
            }
        }
        if (id ==2)
        {
            audio_source.PlayOneShot(buy_sound);
            _plus_click += 50;
            slot_buy_count_5 += 1;
            UpdateRank();
            YandexGame.SaveProgress();
        }
    }
    public void OpenRewardAd(int id)
    {
        if(YandexGame.savesData.ad_showen != 4)
        {
            YandexGame.RewVideoShow(id);
        }
    }
    public void OpenRewardAd2(int id)
    {
        YandexGame.RewVideoShow(id);
    }

    private void FormatNumber(BigInteger number)
    {
        string formattedNumber = FormatNumberShort(number);
        counterText.text = formattedNumber;
    }

    public string FormatNumberShort(BigInteger number)
    {
        string[] suffixes = { num1, num2, num3, num4, num5, num6, num7, num8, num9, num10, num11,
            num12, num13, num14, num15, num16, num17, num18, num19, num20, num21 };
        int suffixIndex = 0;

        // Handle cases where BigInteger is within decimal range
        if (number <= (BigInteger)decimal.MaxValue &&
            number >= (BigInteger)decimal.MinValue)
        {
            decimal numValue = (decimal)number;
            while (numValue >= 1000 && suffixIndex < suffixes.Length)
            {
                numValue /= 1000;
                suffixIndex++;
            }

            if (suffixIndex >= suffixes.Length)
            {
                return max_text;
            }
            else if (suffixIndex > 0)
            {
                return $"{numValue:0.00}{suffixes[suffixIndex - 1]}";
            }
            else
            {
                return number.ToString();
            }
        }
        else
        {
            // Handle cases exceeding decimal range - keep as BigInteger
            BigInteger numValue = number;
            while (numValue >= 1000 && suffixIndex < suffixes.Length)
            {
                numValue /= 1000;
                suffixIndex++;
            }

            if (suffixIndex >= suffixes.Length)
            {
                return max_text;
            }
            else
            {
                return $"{numValue}{suffixes[suffixIndex - 1]}"; // No decimal formatting here
            }
        }
    }

    private void ConveringNumbers()
    {
        bitcoins = ConvertStringToBigInteger(YandexGame.savesData.bitcoins);
        _plus_click = ConvertStringToBigInteger(YandexGame.savesData._plus_click);
        _plus_auto = ConvertStringToBigInteger(YandexGame.savesData._plus_auto);
        slot_buy_count_1 = ConvertStringToBigInteger(YandexGame.savesData.slot_buy_count_1);
        slot_buy_count_2 = ConvertStringToBigInteger(YandexGame.savesData.slot_buy_count_2);
        slot_buy_count_3 = ConvertStringToBigInteger(YandexGame.savesData.slot_buy_count_3);
        slot_buy_count_4 = ConvertStringToBigInteger(YandexGame.savesData.slot_buy_count_4);
        slot_buy_count_5 = ConvertStringToBigInteger(YandexGame.savesData.slot_buy_count_5);
        slot_buy_count_6 = ConvertStringToBigInteger(YandexGame.savesData.slot_buy_count_6);
        slot_buy_count_7 = ConvertStringToBigInteger(YandexGame.savesData.slot_buy_count_7);
        slot_buy_count_8 = ConvertStringToBigInteger(YandexGame.savesData.slot_buy_count_8);
        slot_buy_count_9 = ConvertStringToBigInteger(YandexGame.savesData.slot_buy_count_9);
        slot_buy_count_10 = ConvertStringToBigInteger(YandexGame.savesData.slot_buy_count_10);
        slot_buy_count_11 = ConvertStringToBigInteger(YandexGame.savesData.slot_buy_count_11);
        slot_buy_count_12 = ConvertStringToBigInteger(YandexGame.savesData.slot_buy_count_12);
        slot_buy_count_13 = ConvertStringToBigInteger(YandexGame.savesData.slot_buy_count_13);
        slot_buy_count_14 = ConvertStringToBigInteger(YandexGame.savesData.slot_buy_count_14);
        slot_buy_count_15 = ConvertStringToBigInteger(YandexGame.savesData.slot_buy_count_15);
        slot_buy_count_16 = ConvertStringToBigInteger(YandexGame.savesData.slot_buy_count_16);
        slot_buy_count_17 = ConvertStringToBigInteger(YandexGame.savesData.slot_buy_count_17);
        slot_buy_count_18 = ConvertStringToBigInteger(YandexGame.savesData.slot_buy_count_18);
        slot_buy_count_19 = ConvertStringToBigInteger(YandexGame.savesData.slot_buy_count_19);
        slot_buy_count_20 = ConvertStringToBigInteger(YandexGame.savesData.slot_buy_count_20);
        slot_buy_count_21 = ConvertStringToBigInteger(YandexGame.savesData.slot_buy_count_21);
        slot_buy_count_22 = ConvertStringToBigInteger(YandexGame.savesData.slot_buy_count_22);
        slot_buy_count_23 = ConvertStringToBigInteger(YandexGame.savesData.slot_buy_count_23);
        slot_buy_count_24 = ConvertStringToBigInteger(YandexGame.savesData.slot_buy_count_24);
        slot_buy_count_25 = ConvertStringToBigInteger(YandexGame.savesData.slot_buy_count_25);
        slot_buy_count_26 = ConvertStringToBigInteger(YandexGame.savesData.slot_buy_count_26);
        slot_buy_count_27 = ConvertStringToBigInteger(YandexGame.savesData.slot_buy_count_27);
        slot_buy_count_28 = ConvertStringToBigInteger(YandexGame.savesData.slot_buy_count_28);
        slot_buy_count_29 = ConvertStringToBigInteger(YandexGame.savesData.slot_buy_count_29);
        slot_buy_count_30 = ConvertStringToBigInteger(YandexGame.savesData.slot_buy_count_30);
        slot_buy_count_31 = ConvertStringToBigInteger(YandexGame.savesData.slot_buy_count_31);
        slot_buy_count_32 = ConvertStringToBigInteger(YandexGame.savesData.slot_buy_count_32);
        slot_buy_count_33 = ConvertStringToBigInteger(YandexGame.savesData.slot_buy_count_33);
        slot_buy_count_34 = ConvertStringToBigInteger(YandexGame.savesData.slot_buy_count_34);
        slot_buy_count_35 = ConvertStringToBigInteger(YandexGame.savesData.slot_buy_count_35);
        slot_buy_count_36 = ConvertStringToBigInteger(YandexGame.savesData.slot_buy_count_36);
        slot_buy_count_37 = ConvertStringToBigInteger(YandexGame.savesData.slot_buy_count_37);
        slot_buy_count_38 = ConvertStringToBigInteger(YandexGame.savesData.slot_buy_count_38);
        slot_price_1 = ConvertStringToBigInteger(YandexGame.savesData.slot_price_1);
        slot_price_2 = ConvertStringToBigInteger(YandexGame.savesData.slot_price_2);
        slot_price_3 = ConvertStringToBigInteger(YandexGame.savesData.slot_price_3);
        slot_price_4 = ConvertStringToBigInteger(YandexGame.savesData.slot_price_4);
        slot_price_6 = ConvertStringToBigInteger(YandexGame.savesData.slot_price_6);
        slot_price_7 = ConvertStringToBigInteger(YandexGame.savesData.slot_price_7);
        slot_price_8 = ConvertStringToBigInteger(YandexGame.savesData.slot_price_8);
        slot_price_9 = ConvertStringToBigInteger(YandexGame.savesData.slot_price_9);
        slot_price_10 = ConvertStringToBigInteger(YandexGame.savesData.slot_price_10);
        slot_price_11 = ConvertStringToBigInteger(YandexGame.savesData.slot_price_11);
        slot_price_12 = ConvertStringToBigInteger(YandexGame.savesData.slot_price_12);
        slot_price_13 = ConvertStringToBigInteger(YandexGame.savesData.slot_price_13);
        slot_price_14 = ConvertStringToBigInteger(YandexGame.savesData.slot_price_14);
        slot_price_15 = ConvertStringToBigInteger(YandexGame.savesData.slot_price_15);
        slot_price_16 = ConvertStringToBigInteger(YandexGame.savesData.slot_price_16);
        slot_price_17 = ConvertStringToBigInteger(YandexGame.savesData.slot_price_17);
        slot_price_18 = ConvertStringToBigInteger(YandexGame.savesData.slot_price_18);
        slot_price_19 = ConvertStringToBigInteger(YandexGame.savesData.slot_price_19);
        slot_price_20 = ConvertStringToBigInteger(YandexGame.savesData.slot_price_20);
        slot_price_21 = ConvertStringToBigInteger(YandexGame.savesData.slot_price_21);
        slot_price_22 = ConvertStringToBigInteger(YandexGame.savesData.slot_price_22);
        slot_price_23 = ConvertStringToBigInteger(YandexGame.savesData.slot_price_23);
        slot_price_24 = ConvertStringToBigInteger(YandexGame.savesData.slot_price_24);
        slot_price_25 = ConvertStringToBigInteger(YandexGame.savesData.slot_price_25);
        slot_price_26 = ConvertStringToBigInteger(YandexGame.savesData.slot_price_26);
        slot_price_27 = ConvertStringToBigInteger(YandexGame.savesData.slot_price_27);
        slot_price_28 = ConvertStringToBigInteger(YandexGame.savesData.slot_price_28);
        slot_price_29 = ConvertStringToBigInteger(YandexGame.savesData.slot_price_29);
        slot_price_30 = ConvertStringToBigInteger(YandexGame.savesData.slot_price_30);
        slot_price_31 = ConvertStringToBigInteger(YandexGame.savesData.slot_price_31);
        slot_price_32 = ConvertStringToBigInteger(YandexGame.savesData.slot_price_32);
        slot_price_33 = ConvertStringToBigInteger(YandexGame.savesData.slot_price_33);
        slot_price_34 = ConvertStringToBigInteger(YandexGame.savesData.slot_price_34);
    }
    private void ConveringNumbersBack()
    {
        YandexGame.savesData.bitcoins = ConvertBigIntegerToString(bitcoins);
        YandexGame.savesData._plus_click = ConvertBigIntegerToString(_plus_click);
        YandexGame.savesData._plus_auto = ConvertBigIntegerToString(_plus_auto);
        YandexGame.savesData.slot_buy_count_1 = ConvertBigIntegerToString(slot_buy_count_1);
        YandexGame.savesData.slot_buy_count_2 = ConvertBigIntegerToString(slot_buy_count_2);
        YandexGame.savesData.slot_buy_count_3 = ConvertBigIntegerToString(slot_buy_count_3);
        YandexGame.savesData.slot_buy_count_4 = ConvertBigIntegerToString(slot_buy_count_4);
        YandexGame.savesData.slot_buy_count_5 = ConvertBigIntegerToString(slot_buy_count_5);
        YandexGame.savesData.slot_buy_count_6 = ConvertBigIntegerToString(slot_buy_count_6);
        YandexGame.savesData.slot_buy_count_7 = ConvertBigIntegerToString(slot_buy_count_7);
        YandexGame.savesData.slot_buy_count_8 = ConvertBigIntegerToString(slot_buy_count_8);
        YandexGame.savesData.slot_buy_count_9 = ConvertBigIntegerToString(slot_buy_count_9);
        YandexGame.savesData.slot_buy_count_10 = ConvertBigIntegerToString(slot_buy_count_10);
        YandexGame.savesData.slot_buy_count_11 = ConvertBigIntegerToString(slot_buy_count_11);
        YandexGame.savesData.slot_buy_count_12 = ConvertBigIntegerToString(slot_buy_count_12);
        YandexGame.savesData.slot_buy_count_13 = ConvertBigIntegerToString(slot_buy_count_13);
        YandexGame.savesData.slot_buy_count_14 = ConvertBigIntegerToString(slot_buy_count_14);
        YandexGame.savesData.slot_buy_count_15 = ConvertBigIntegerToString(slot_buy_count_15);
        YandexGame.savesData.slot_buy_count_16 = ConvertBigIntegerToString(slot_buy_count_16);
        YandexGame.savesData.slot_buy_count_17 = ConvertBigIntegerToString(slot_buy_count_17);
        YandexGame.savesData.slot_buy_count_18 = ConvertBigIntegerToString(slot_buy_count_18);
        YandexGame.savesData.slot_buy_count_19 = ConvertBigIntegerToString(slot_buy_count_19);
        YandexGame.savesData.slot_buy_count_20 = ConvertBigIntegerToString(slot_buy_count_20);
        YandexGame.savesData.slot_buy_count_21 = ConvertBigIntegerToString(slot_buy_count_21);
        YandexGame.savesData.slot_buy_count_22 = ConvertBigIntegerToString(slot_buy_count_22);
        YandexGame.savesData.slot_buy_count_23 = ConvertBigIntegerToString(slot_buy_count_23);
        YandexGame.savesData.slot_buy_count_24 = ConvertBigIntegerToString(slot_buy_count_24);
        YandexGame.savesData.slot_buy_count_25 = ConvertBigIntegerToString(slot_buy_count_25);
        YandexGame.savesData.slot_buy_count_26 = ConvertBigIntegerToString(slot_buy_count_26);
        YandexGame.savesData.slot_buy_count_27 = ConvertBigIntegerToString(slot_buy_count_27);
        YandexGame.savesData.slot_buy_count_28 = ConvertBigIntegerToString(slot_buy_count_28);
        YandexGame.savesData.slot_buy_count_29 = ConvertBigIntegerToString(slot_buy_count_29);
        YandexGame.savesData.slot_buy_count_30 = ConvertBigIntegerToString(slot_buy_count_30);
        YandexGame.savesData.slot_buy_count_31 = ConvertBigIntegerToString(slot_buy_count_31);
        YandexGame.savesData.slot_buy_count_32 = ConvertBigIntegerToString(slot_buy_count_32);
        YandexGame.savesData.slot_buy_count_33 = ConvertBigIntegerToString(slot_buy_count_33);
        YandexGame.savesData.slot_buy_count_34 = ConvertBigIntegerToString(slot_buy_count_34);
        YandexGame.savesData.slot_buy_count_35 = ConvertBigIntegerToString(slot_buy_count_35);
        YandexGame.savesData.slot_buy_count_36 = ConvertBigIntegerToString(slot_buy_count_36);
        YandexGame.savesData.slot_buy_count_37 = ConvertBigIntegerToString(slot_buy_count_37);
        YandexGame.savesData.slot_buy_count_38 = ConvertBigIntegerToString(slot_buy_count_38);
        YandexGame.savesData.slot_price_1 = ConvertBigIntegerToString(slot_price_1);
        YandexGame.savesData.slot_price_2 = ConvertBigIntegerToString(slot_price_2);
        YandexGame.savesData.slot_price_3 = ConvertBigIntegerToString(slot_price_3);
        YandexGame.savesData.slot_price_4 = ConvertBigIntegerToString(slot_price_4);
        YandexGame.savesData.slot_price_6 = ConvertBigIntegerToString(slot_price_6);
        YandexGame.savesData.slot_price_7 = ConvertBigIntegerToString(slot_price_7);
        YandexGame.savesData.slot_price_8 = ConvertBigIntegerToString(slot_price_8);
        YandexGame.savesData.slot_price_9 = ConvertBigIntegerToString(slot_price_9);
        YandexGame.savesData.slot_price_10 = ConvertBigIntegerToString(slot_price_10);
        YandexGame.savesData.slot_price_11 = ConvertBigIntegerToString(slot_price_11);
        YandexGame.savesData.slot_price_12 = ConvertBigIntegerToString(slot_price_12);
        YandexGame.savesData.slot_price_13 = ConvertBigIntegerToString(slot_price_13);
        YandexGame.savesData.slot_price_14 = ConvertBigIntegerToString(slot_price_14);
        YandexGame.savesData.slot_price_15 = ConvertBigIntegerToString(slot_price_15);
        YandexGame.savesData.slot_price_16 = ConvertBigIntegerToString(slot_price_16);
        YandexGame.savesData.slot_price_17 = ConvertBigIntegerToString(slot_price_17);
        YandexGame.savesData.slot_price_18 = ConvertBigIntegerToString(slot_price_18);
        YandexGame.savesData.slot_price_19 = ConvertBigIntegerToString(slot_price_19);
        YandexGame.savesData.slot_price_20 = ConvertBigIntegerToString(slot_price_20);
        YandexGame.savesData.slot_price_21 = ConvertBigIntegerToString(slot_price_21);
        YandexGame.savesData.slot_price_22 = ConvertBigIntegerToString(slot_price_22);
        YandexGame.savesData.slot_price_23 = ConvertBigIntegerToString(slot_price_23);
        YandexGame.savesData.slot_price_24 = ConvertBigIntegerToString(slot_price_24);
        YandexGame.savesData.slot_price_25 = ConvertBigIntegerToString(slot_price_25);
        YandexGame.savesData.slot_price_26 = ConvertBigIntegerToString(slot_price_26);
        YandexGame.savesData.slot_price_27 = ConvertBigIntegerToString(slot_price_27);
        YandexGame.savesData.slot_price_28 = ConvertBigIntegerToString(slot_price_28);
        YandexGame.savesData.slot_price_29 = ConvertBigIntegerToString(slot_price_29);
        YandexGame.savesData.slot_price_30 = ConvertBigIntegerToString(slot_price_30);
        YandexGame.savesData.slot_price_31 = ConvertBigIntegerToString(slot_price_31);
        YandexGame.savesData.slot_price_32 = ConvertBigIntegerToString(slot_price_32);
        YandexGame.savesData.slot_price_33 = ConvertBigIntegerToString(slot_price_33);
        YandexGame.savesData.slot_price_34 = ConvertBigIntegerToString(slot_price_34);
        YandexGame.savesData.slot_price_35 = ConvertBigIntegerToString(slot_price_35);
        YandexGame.savesData.slot_price_36 = ConvertBigIntegerToString(slot_price_36);
        YandexGame.savesData.slot_price_37 = ConvertBigIntegerToString(slot_price_37);
        YandexGame.savesData.slot_price_38 = ConvertBigIntegerToString(slot_price_38);
    }
    public string ConvertBigIntegerToString(BigInteger bigIntegerValue)
    {
        string stringValue = bigIntegerValue.ToString();

        return stringValue;
    }

    private BigInteger ConvertStringToBigInteger(string stringValue)
    {
        BigInteger bigIntegerValue;

        if (BigInteger.TryParse(stringValue, out bigIntegerValue))
        {
            return bigIntegerValue;
        }
        else
        {
            return BigInteger.Zero;
        }
    }

    public void ProgressUp(float progress)
    {
        if(YandexGame.savesData.current_comp != 15)
        {
            YandexGame.savesData.currentProgress += progress;
            YandexGame.savesData.currentProgress = Mathf.Clamp(YandexGame.savesData.currentProgress, 0, 100);
            progressImage.fillAmount = YandexGame.savesData.currentProgress / 100f;
            progressPercent.text = Mathf.RoundToInt(progressImage.fillAmount * 100) + "%";
            if (YandexGame.savesData.currentProgress == 100f)
            {
                if(isALreadyBuyShow == false)
                {
                    audio_source.PlayOneShot(new_level_can_snd); 
                    YandexGame.savesData.isBuyBtnShow = true;
                    isALreadyBuyShow = true;
                    showBuyLevel();
                }
            }
        }
    }
    private void showBuyLevel()
    {
        string price2 = "5500";
        string price3 = "75250";
        string price4 = "1550000";
        string price5 = "15500000";
        string price6 = "50750000";
        string price7 = "500000000";
        string price8 = "1500000000";
        string price9 = "8750000000";
        string price10 = "17250000000";
        string price11 = "65450000000";
        string price12 = "150000000000";
        string price13 = "1000000000000";
        string price14 = "15250000000000";
        string price15 = "5500000000000000";
        switch (YandexGame.savesData.current_comp)
        {
            case 1:
                //2
                new_level_price_num = ConvertStringToBigInteger(price2);
                break;
            case 2:
                //3
                new_level_price_num = ConvertStringToBigInteger(price3);
                break;
            case 3:
                //4
                new_level_price_num = ConvertStringToBigInteger(price4);
                break;
            case 4:
                //5
                new_level_price_num = ConvertStringToBigInteger(price5);
                break;
            case 5:
                //6
                new_level_price_num = ConvertStringToBigInteger(price6);
                break;
            case 6:
                //7
                new_level_price_num = ConvertStringToBigInteger(price7);
                break;
            case 7:
                //8
                new_level_price_num = ConvertStringToBigInteger(price8);
                break;
            case 8:
                //9
                new_level_price_num = ConvertStringToBigInteger(price9);
                break;
            case 9:
                //10
                new_level_price_num = ConvertStringToBigInteger(price10);
                break;
            case 10:
                //11
                new_level_price_num = ConvertStringToBigInteger(price11);
                break;
            case 11:
                //12
                new_level_price_num = ConvertStringToBigInteger(price12);
                break;
            case 12:
                //13
                new_level_price_num = ConvertStringToBigInteger(price13);
                break;
            case 13:
                //14
                new_level_price_num = ConvertStringToBigInteger(price14);
                break;
            case 14:
                //15
                new_level_price_num = ConvertStringToBigInteger(price15);
                break;
        }
        progressPercent.gameObject.SetActive(false);
        new_levelOBJ.SetActive(true);
        YandexGame.SaveProgress();
    }
    public void hideBuyLevel()
    {
        if(YandexGame.savesData.current_comp < 15)
        {
            if (bitcoins >= new_level_price_num)
            {
                StartCoroutine(StartSunScaleAndRotate());
                YandexGame.savesData.isBuyBtnShow = false;
                new_levelOBJ.SetActive(false);
                progressPercent.text = "0%";
                progressImage.fillAmount = 0f;
                YandexGame.savesData.current_comp += 1;
                YandexGame.savesData.currentProgress = 0f;
                audio_source.PlayOneShot(newComp);
                YandexGame.NewLeaderboardScores("complevel", YandexGame.savesData.current_comp);
                bitcoins -= new_level_price_num;
                progressPercent.gameObject.SetActive(true);
                foreach (Transform child in lbParent)
                {
                    Destroy(child.gameObject);
                }
                Instantiate(leaderBoard, lbParent);
                Update_comp();
                YandexGame.SaveProgress();
                isALreadyBuyShow = false;
                YandexGame.savesData.ad_showen = 0;
                ad_showen_text.text = YandexGame.savesData.ad_showen + "/4";
                forbiddenImg.SetActive(false);
            }
            else
            {
                audio_source.PlayOneShot(noMoney);
                StartBlinkingNoMoney();
            }
        }
    }
    private IEnumerator StartSunScaleAndRotate()
    {
        allowRotate = true;
        float duration = 2f;
        float startTime = Time.time;

        while (Time.time - startTime < duration)
        {
            float t = (Time.time - startTime) / duration;
            sunImage.color = new Color(1, 1, 1, Mathf.Lerp(0, 1, t));
            sunImage.transform.localScale = UnityEngine.Vector3.Lerp(UnityEngine.Vector3.one, UnityEngine.Vector3.one * targetScale, t);
            sunImage.transform.Rotate(UnityEngine.Vector3.forward * 100 * Time.deltaTime);
            yield return null;
        }

        duration = 2f;
        startTime = Time.time;

        while (Time.time - startTime < duration)
        {
            float t = (Time.time - startTime) / duration;
            sunImage.color = new Color(1, 1, 1, Mathf.Lerp(1, 0, t));
            yield return null;
        }
        allowRotate = false;
    }

    private void UpdateRank()
    {
        BigInteger generalPlus = slot_buy_count_1 + slot_buy_count_2 + slot_buy_count_3 + slot_buy_count_4 + slot_buy_count_5 +
            slot_buy_count_6 + slot_buy_count_7 + slot_buy_count_8 + slot_buy_count_9 + slot_buy_count_10 + slot_buy_count_11 +
            slot_buy_count_12 + slot_buy_count_13 + slot_buy_count_14 + slot_buy_count_15 + slot_buy_count_16 + slot_buy_count_17 +
            slot_buy_count_18 + slot_buy_count_19 + slot_buy_count_20 + slot_buy_count_21 + slot_buy_count_22 + slot_buy_count_23 +
            slot_buy_count_24 + slot_buy_count_25 + slot_buy_count_26 + slot_buy_count_27 + slot_buy_count_28 + slot_buy_count_29 +
            slot_buy_count_30 + slot_buy_count_31 + slot_buy_count_32 + slot_buy_count_33 + slot_buy_count_34 + slot_buy_count_35 +
            slot_buy_count_36 + slot_buy_count_37 + slot_buy_count_38;

        switch (generalPlus)
        {
            case var _ when generalPlus >= 2000:
                rankText.text = rank10;
                break;
            case var _ when generalPlus >= 1500:
                rankText.text = rank9;
                break;
            case var _ when generalPlus >= 1250:
                rankText.text = rank8;
                break;
            case var _ when generalPlus >= 1000:
                rankText.text = rank7;
                break;
            case var _ when generalPlus >= 750:
                rankText.text = rank6;
                break;
            case var _ when generalPlus >= 500:
                rankText.text = rank5;
                break;
            case var _ when generalPlus >= 250:
                rankText.text = rank4;
                break;
            case var _ when generalPlus >= 100:
                rankText.text = rank3;
                break;
            case var _ when generalPlus >= 50:
                rankText.text = rank2;
                break;
            default:
                rankText.text = rank1;
                break;
        }
    }
}
