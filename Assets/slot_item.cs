using UnityEngine;
using UnityEngine.UI;

public class slot_item : MonoBehaviour
{
    private GameObject black_background, buy_countText, coin_text;
    [SerializeField] private Manager _Manager;
    private void Start()
    {
        if (!gameObject.name.Equals("slot5"))
        {
            black_background = transform.Find("black_image").gameObject;
            coin_text = transform.Find("price/coin_text").gameObject;
        }
        buy_countText = transform.Find("buy_count").gameObject;
    }
    void Update()
    {
        Update_slot_prices_text();
        Update_buy_count_text();
        if (gameObject.name.Equals("slot1") && _Manager.bitcoins >= _Manager.slot_price_1)
        {
            black_background.SetActive(false);
        }
        if (gameObject.name.Equals("slot1") && _Manager.bitcoins < _Manager.slot_price_1)
        {
            black_background.SetActive(true);
        }

        if (gameObject.name.Equals("slot2") && _Manager.bitcoins >= _Manager.slot_price_2)
        {
            black_background.SetActive(false);
        }
        if (gameObject.name.Equals("slot2") && _Manager.bitcoins < _Manager.slot_price_2)
        {
            black_background.SetActive(true);
        }

        if (gameObject.name.Equals("slot3") && _Manager.bitcoins >= _Manager.slot_price_3)
        {
            black_background.SetActive(false);
        }
        if (gameObject.name.Equals("slot3") && _Manager.bitcoins < _Manager.slot_price_3)
        {
            black_background.SetActive(true);
        }
        if (gameObject.name.Equals("slot4") && _Manager.bitcoins >= _Manager.slot_price_4)
        {
            black_background.SetActive(false);
        }
        if (gameObject.name.Equals("slot4") && _Manager.bitcoins < _Manager.slot_price_4)
        {
            black_background.SetActive(true);
        }
        if (gameObject.name.Equals("slot6") && _Manager.bitcoins >= _Manager.slot_price_6)
        {
            black_background.SetActive(false);
        }
        if (gameObject.name.Equals("slot6") && _Manager.bitcoins < _Manager.slot_price_6)
        {
            black_background.SetActive(true);
        }
        if (gameObject.name.Equals("slot7") && _Manager.bitcoins >= _Manager.slot_price_7)
        {
            black_background.SetActive(false);
        }
        if (gameObject.name.Equals("slot7") && _Manager.bitcoins < _Manager.slot_price_7)
        {
            black_background.SetActive(true);
        }
        if (gameObject.name.Equals("slot8") && _Manager.bitcoins >= _Manager.slot_price_8)
        {
            black_background.SetActive(false);
        }
        if (gameObject.name.Equals("slot8") && _Manager.bitcoins < _Manager.slot_price_8)
        {
            black_background.SetActive(true);
        }
        if (gameObject.name.Equals("slot9") && _Manager.bitcoins >= _Manager.slot_price_9)
        {
            black_background.SetActive(false);
        }
        if (gameObject.name.Equals("slot9") && _Manager.bitcoins < _Manager.slot_price_9)
        {
            black_background.SetActive(true);
        }

        if (gameObject.name.Equals("slot10") && _Manager.bitcoins >= _Manager.slot_price_10)
        {
            black_background.SetActive(false);
        }
        if (gameObject.name.Equals("slot10") && _Manager.bitcoins < _Manager.slot_price_10)
        {
            black_background.SetActive(true);
        }

        if (gameObject.name.Equals("slot11") && _Manager.bitcoins >= _Manager.slot_price_11)
        {
            black_background.SetActive(false);
        }
        if (gameObject.name.Equals("slot11") && _Manager.bitcoins < _Manager.slot_price_11)
        {
            black_background.SetActive(true);
        }

        if (gameObject.name.Equals("slot12") && _Manager.bitcoins >= _Manager.slot_price_12)
        {
            black_background.SetActive(false);
        }
        if (gameObject.name.Equals("slot12") && _Manager.bitcoins < _Manager.slot_price_12)
        {
            black_background.SetActive(true);
        }

        if (gameObject.name.Equals("slot13") && _Manager.bitcoins >= _Manager.slot_price_13)
        {
            black_background.SetActive(false);
        }
        if (gameObject.name.Equals("slot13") && _Manager.bitcoins < _Manager.slot_price_13)
        {
            black_background.SetActive(true);
        }

        if (gameObject.name.Equals("slot14") && _Manager.bitcoins >= _Manager.slot_price_14)
        {
            black_background.SetActive(false);
        }
        if (gameObject.name.Equals("slot14") && _Manager.bitcoins < _Manager.slot_price_14)
        {
            black_background.SetActive(true);
        }

        if (gameObject.name.Equals("slot15") && _Manager.bitcoins >= _Manager.slot_price_15)
        {
            black_background.SetActive(false);
        }
        if (gameObject.name.Equals("slot15") && _Manager.bitcoins < _Manager.slot_price_15)
        {
            black_background.SetActive(true);
        }

        if (gameObject.name.Equals("slot16") && _Manager.bitcoins >= _Manager.slot_price_16)
        {
            black_background.SetActive(false);
        }
        if (gameObject.name.Equals("slot16") && _Manager.bitcoins < _Manager.slot_price_16)
        {
            black_background.SetActive(true);
        }

        if (gameObject.name.Equals("slot17") && _Manager.bitcoins >= _Manager.slot_price_17)
        {
            black_background.SetActive(false);
        }
        if (gameObject.name.Equals("slot17") && _Manager.bitcoins < _Manager.slot_price_17)
        {
            black_background.SetActive(true);
        }

        if (gameObject.name.Equals("slot18") && _Manager.bitcoins >= _Manager.slot_price_18)
        {
            black_background.SetActive(false);
        }
        if (gameObject.name.Equals("slot18") && _Manager.bitcoins < _Manager.slot_price_18)
        {
            black_background.SetActive(true);
        }

        if (gameObject.name.Equals("slot19") && _Manager.bitcoins >= _Manager.slot_price_19)
        {
            black_background.SetActive(false);
        }
        if (gameObject.name.Equals("slot19") && _Manager.bitcoins < _Manager.slot_price_19)
        {
            black_background.SetActive(true);
        }

        if (gameObject.name.Equals("slot20") && _Manager.bitcoins >= _Manager.slot_price_20)
        {
            black_background.SetActive(false);
        }
        if (gameObject.name.Equals("slot20") && _Manager.bitcoins < _Manager.slot_price_20)
        {
            black_background.SetActive(true);
        }
        if (gameObject.name.Equals("slot21") && _Manager.bitcoins >= _Manager.slot_price_21)
        {
            black_background.SetActive(false);
        }
        if (gameObject.name.Equals("slot21") && _Manager.bitcoins < _Manager.slot_price_21)
        {
            black_background.SetActive(true);
        }
        if (gameObject.name.Equals("slot22") && _Manager.bitcoins >= _Manager.slot_price_22)
        {
            black_background.SetActive(false);
        }
        if (gameObject.name.Equals("slot22") && _Manager.bitcoins < _Manager.slot_price_22)
        {
            black_background.SetActive(true);
        }
        if (gameObject.name.Equals("slot23") && _Manager.bitcoins >= _Manager.slot_price_23)
        {
            black_background.SetActive(false);
        }
        if (gameObject.name.Equals("slot23") && _Manager.bitcoins < _Manager.slot_price_23)
        {
            black_background.SetActive(true);
        }
        if (gameObject.name.Equals("slot24") && _Manager.bitcoins >= _Manager.slot_price_24)
        {
            black_background.SetActive(false);
        }
        if (gameObject.name.Equals("slot24") && _Manager.bitcoins < _Manager.slot_price_24)
        {
            black_background.SetActive(true);
        }

        if (gameObject.name.Equals("slot25") && _Manager.bitcoins >= _Manager.slot_price_25)
        {
            black_background.SetActive(false);
        }
        if (gameObject.name.Equals("slot25") && _Manager.bitcoins < _Manager.slot_price_25)
        {
            black_background.SetActive(true);
        }

        if (gameObject.name.Equals("slot26") && _Manager.bitcoins >= _Manager.slot_price_26)
        {
            black_background.SetActive(false);
        }
        if (gameObject.name.Equals("slot26") && _Manager.bitcoins < _Manager.slot_price_26)
        {
            black_background.SetActive(true);
        }

        if (gameObject.name.Equals("slot27") && _Manager.bitcoins >= _Manager.slot_price_27)
        {
            black_background.SetActive(false);
        }
        if (gameObject.name.Equals("slot27") && _Manager.bitcoins < _Manager.slot_price_27)
        {
            black_background.SetActive(true);
        }

        if (gameObject.name.Equals("slot28") && _Manager.bitcoins >= _Manager.slot_price_28)
        {
            black_background.SetActive(false);
        }
        if (gameObject.name.Equals("slot28") && _Manager.bitcoins < _Manager.slot_price_28)
        {
            black_background.SetActive(true);
        }

        if (gameObject.name.Equals("slot29") && _Manager.bitcoins >= _Manager.slot_price_29)
        {
            black_background.SetActive(false);
        }
        if (gameObject.name.Equals("slot29") && _Manager.bitcoins < _Manager.slot_price_29)
        {
            black_background.SetActive(true);
        }

        if (gameObject.name.Equals("slot30") && _Manager.bitcoins >= _Manager.slot_price_30)
        {
            black_background.SetActive(false);
        }
        if (gameObject.name.Equals("slot30") && _Manager.bitcoins < _Manager.slot_price_30)
        {
            black_background.SetActive(true);
        }

        if (gameObject.name.Equals("slot31") && _Manager.bitcoins >= _Manager.slot_price_31)
        {
            black_background.SetActive(false);
        }
        if (gameObject.name.Equals("slot31") && _Manager.bitcoins < _Manager.slot_price_31)
        {
            black_background.SetActive(true);
        }

        if (gameObject.name.Equals("slot32") && _Manager.bitcoins >= _Manager.slot_price_32)
        {
            black_background.SetActive(false);
        }
        if (gameObject.name.Equals("slot32") && _Manager.bitcoins < _Manager.slot_price_32)
        {
            black_background.SetActive(true);
        }

        if (gameObject.name.Equals("slot33") && _Manager.bitcoins >= _Manager.slot_price_33)
        {
            black_background.SetActive(false);
        }
        if (gameObject.name.Equals("slot33") && _Manager.bitcoins < _Manager.slot_price_33)
        {
            black_background.SetActive(true);
        }

        if (gameObject.name.Equals("slot34") && _Manager.bitcoins >= _Manager.slot_price_34)
        {
            black_background.SetActive(false);
        }
        if (gameObject.name.Equals("slot34") && _Manager.bitcoins < _Manager.slot_price_34)
        {
            black_background.SetActive(true);
        }

        if (gameObject.name.Equals("slot35") && _Manager.bitcoins >= _Manager.slot_price_35)
        {
            black_background.SetActive(false);
        }
        if (gameObject.name.Equals("slot35") && _Manager.bitcoins < _Manager.slot_price_35)
        {
            black_background.SetActive(true);
        }

        if (gameObject.name.Equals("slot36") && _Manager.bitcoins >= _Manager.slot_price_36)
        {
            black_background.SetActive(false);
        }
        if (gameObject.name.Equals("slot36") && _Manager.bitcoins < _Manager.slot_price_36)
        {
            black_background.SetActive(true);
        }

        if (gameObject.name.Equals("slot37") && _Manager.bitcoins >= _Manager.slot_price_37)
        {
            black_background.SetActive(false);
        }
        if (gameObject.name.Equals("slot37") && _Manager.bitcoins < _Manager.slot_price_37)
        {
            black_background.SetActive(true);
        }

        if (gameObject.name.Equals("slot38") && _Manager.bitcoins >= _Manager.slot_price_38)
        {
            black_background.SetActive(false);
        }
        if (gameObject.name.Equals("slot38") && _Manager.bitcoins < _Manager.slot_price_38)
        {
            black_background.SetActive(true);
        }
    }
    public void Update_buy_count_text()
    {
        if (gameObject.name.Equals("slot1") && _Manager.slot_buy_count_1 != 0)
        {
            buy_countText.SetActive(true);
            buy_countText.GetComponent<Text>().text = "x" + _Manager.slot_buy_count_1.ToString();
        }
        if (gameObject.name.Equals("slot2") && _Manager.slot_buy_count_2 != 0)
        {
            buy_countText.SetActive(true);
            buy_countText.GetComponent<Text>().text = "x" + _Manager.slot_buy_count_2.ToString();
        }
        if (gameObject.name.Equals("slot3") && _Manager.slot_buy_count_3 != 0)
        {
            buy_countText.SetActive(true);
            buy_countText.GetComponent<Text>().text = "x" + _Manager.slot_buy_count_3.ToString();
        }
        if (gameObject.name.Equals("slot4") && _Manager.slot_buy_count_4 != 0)
        {
            buy_countText.SetActive(true);
            buy_countText.GetComponent<Text>().text = "x" + _Manager.slot_buy_count_4.ToString();
        }
        if (gameObject.name.Equals("slot5") && _Manager.slot_buy_count_5 != 0)
        {
            buy_countText.SetActive(true);
            buy_countText.GetComponent<Text>().text = "x" + _Manager.slot_buy_count_5.ToString();
        }
        if (gameObject.name.Equals("slot6") && _Manager.slot_buy_count_6 != 0)
        {
            buy_countText.SetActive(true);
            buy_countText.GetComponent<Text>().text = "x" + _Manager.slot_buy_count_6.ToString();
        }
        if (gameObject.name.Equals("slot7") && _Manager.slot_buy_count_7 != 0)
        {
            buy_countText.SetActive(true);
            buy_countText.GetComponent<Text>().text = "x" + _Manager.slot_buy_count_7.ToString();
        }
        if (gameObject.name.Equals("slot8") && _Manager.slot_buy_count_8 != 0)
        {
            buy_countText.SetActive(true);
            buy_countText.GetComponent<Text>().text = "x" + _Manager.slot_buy_count_8.ToString();
        }
        if (gameObject.name.Equals("slot9") && _Manager.slot_buy_count_9 != 0)
        {
            buy_countText.SetActive(true);
            buy_countText.GetComponent<Text>().text = "x" + _Manager.slot_buy_count_9.ToString();
        }

        if (gameObject.name.Equals("slot10") && _Manager.slot_buy_count_10 != 0)
        {
            buy_countText.SetActive(true);
            buy_countText.GetComponent<Text>().text = "x" + _Manager.slot_buy_count_10.ToString();
        }

        if (gameObject.name.Equals("slot11") && _Manager.slot_buy_count_11 != 0)
        {
            buy_countText.SetActive(true);
            buy_countText.GetComponent<Text>().text = "x" + _Manager.slot_buy_count_11.ToString();
        }

        if (gameObject.name.Equals("slot12") && _Manager.slot_buy_count_12 != 0)
        {
            buy_countText.SetActive(true);
            buy_countText.GetComponent<Text>().text = "x" + _Manager.slot_buy_count_12.ToString();
        }

        if (gameObject.name.Equals("slot13") && _Manager.slot_buy_count_13 != 0)
        {
            buy_countText.SetActive(true);
            buy_countText.GetComponent<Text>().text = "x" + _Manager.slot_buy_count_13.ToString();
        }

        if (gameObject.name.Equals("slot14") && _Manager.slot_buy_count_14 != 0)
        {
            buy_countText.SetActive(true);
            buy_countText.GetComponent<Text>().text = "x" + _Manager.slot_buy_count_14.ToString();
        }

        if (gameObject.name.Equals("slot15") && _Manager.slot_buy_count_15 != 0)
        {
            buy_countText.SetActive(true);
            buy_countText.GetComponent<Text>().text = "x" + _Manager.slot_buy_count_15.ToString();
        }

        if (gameObject.name.Equals("slot16") && _Manager.slot_buy_count_16 != 0)
        {
            buy_countText.SetActive(true);
            buy_countText.GetComponent<Text>().text = "x" + _Manager.slot_buy_count_16.ToString();
        }

        if (gameObject.name.Equals("slot17") && _Manager.slot_buy_count_17 != 0)
        {
            buy_countText.SetActive(true);
            buy_countText.GetComponent<Text>().text = "x" + _Manager.slot_buy_count_17.ToString();
        }

        if (gameObject.name.Equals("slot18") && _Manager.slot_buy_count_18 != 0)
        {
            buy_countText.SetActive(true);
            buy_countText.GetComponent<Text>().text = "x" + _Manager.slot_buy_count_18.ToString();
        }

        if (gameObject.name.Equals("slot19") && _Manager.slot_buy_count_19 != 0)
        {
            buy_countText.SetActive(true);
            buy_countText.GetComponent<Text>().text = "x" + _Manager.slot_buy_count_19.ToString();
        }

        if (gameObject.name.Equals("slot20") && _Manager.slot_buy_count_20 != 0)
        {
            buy_countText.SetActive(true);
            buy_countText.GetComponent<Text>().text = "x" + _Manager.slot_buy_count_20.ToString();
        }

        if (gameObject.name.Equals("slot21") && _Manager.slot_buy_count_21 != 0)
        {
            buy_countText.SetActive(true);
            buy_countText.GetComponent<Text>().text = "x" + _Manager.slot_buy_count_21.ToString();
        }

        if (gameObject.name.Equals("slot22") && _Manager.slot_buy_count_22 != 0)
        {
            buy_countText.SetActive(true);
            buy_countText.GetComponent<Text>().text = "x" + _Manager.slot_buy_count_22.ToString();
        }

        if (gameObject.name.Equals("slot23") && _Manager.slot_buy_count_23 != 0)
        {
            buy_countText.SetActive(true);
            buy_countText.GetComponent<Text>().text = "x" + _Manager.slot_buy_count_23.ToString();
        }

        if (gameObject.name.Equals("slot24") && _Manager.slot_buy_count_24 != 0)
        {
            buy_countText.SetActive(true);
            buy_countText.GetComponent<Text>().text = "x" + _Manager.slot_buy_count_24.ToString();
        }

        if (gameObject.name.Equals("slot25") && _Manager.slot_buy_count_25 != 0)
        {
            buy_countText.SetActive(true);
            buy_countText.GetComponent<Text>().text = "x" + _Manager.slot_buy_count_25.ToString();
        }

        if (gameObject.name.Equals("slot26") && _Manager.slot_buy_count_26 != 0)
        {
            buy_countText.SetActive(true);
            buy_countText.GetComponent<Text>().text = "x" + _Manager.slot_buy_count_26.ToString();
        }

        if (gameObject.name.Equals("slot27") && _Manager.slot_buy_count_27 != 0)
        {
            buy_countText.SetActive(true);
            buy_countText.GetComponent<Text>().text = "x" + _Manager.slot_buy_count_27.ToString();
        }

        if (gameObject.name.Equals("slot28") && _Manager.slot_buy_count_28 != 0)
        {
            buy_countText.SetActive(true);
            buy_countText.GetComponent<Text>().text = "x" + _Manager.slot_buy_count_28.ToString();
        }

        if (gameObject.name.Equals("slot29") && _Manager.slot_buy_count_29 != 0)
        {
            buy_countText.SetActive(true);
            buy_countText.GetComponent<Text>().text = "x" + _Manager.slot_buy_count_29.ToString();
        }

        if (gameObject.name.Equals("slot30") && _Manager.slot_buy_count_30 != 0)
        {
            buy_countText.SetActive(true);
            buy_countText.GetComponent<Text>().text = "x" + _Manager.slot_buy_count_30.ToString();
        }

        if (gameObject.name.Equals("slot31") && _Manager.slot_buy_count_31 != 0)
        {
            buy_countText.SetActive(true);
            buy_countText.GetComponent<Text>().text = "x" + _Manager.slot_buy_count_31.ToString();
        }

        if (gameObject.name.Equals("slot32") && _Manager.slot_buy_count_32 != 0)
        {
            buy_countText.SetActive(true);
            buy_countText.GetComponent<Text>().text = "x" + _Manager.slot_buy_count_32 .ToString();
        }

        if (gameObject.name.Equals("slot33") && _Manager.slot_buy_count_33 != 0)
        {
            buy_countText.SetActive(true);
            buy_countText.GetComponent<Text>().text = "x" + _Manager.slot_buy_count_33.ToString();
        }

        if (gameObject.name.Equals("slot34") && _Manager.slot_buy_count_34 != 0)
        {
            buy_countText.SetActive(true);
            buy_countText.GetComponent<Text>().text = "x" + _Manager.slot_buy_count_34.ToString();
        }

        if (gameObject.name.Equals("slot35") && _Manager.slot_buy_count_35 != 0)
        {
            buy_countText.SetActive(true);
            buy_countText.GetComponent<Text>().text = "x" + _Manager.slot_buy_count_35.ToString();
        }

        if (gameObject.name.Equals("slot36") && _Manager.slot_buy_count_36 != 0)
        {
            buy_countText.SetActive(true);
            buy_countText.GetComponent<Text>().text = "x" + _Manager.slot_buy_count_36.ToString();
        }

        if (gameObject.name.Equals("slot37") && _Manager.slot_buy_count_37 != 0)
        {
            buy_countText.SetActive(true);
            buy_countText.GetComponent<Text>().text = "x" + _Manager.slot_buy_count_37.ToString();
        }

        if (gameObject.name.Equals("slot38") && _Manager.slot_buy_count_38 != 0)
        {
            buy_countText.SetActive(true);
            buy_countText.GetComponent<Text>().text = "x" + _Manager.slot_buy_count_38.ToString();
        }
    }
    public void Update_slot_prices_text()
    {
        if (gameObject.name.Equals("slot1"))
        {
            coin_text.GetComponent<Text>().text = _Manager.FormatNumberShort(_Manager.slot_price_1);
        }
        if (gameObject.name.Equals("slot2"))
        {
            coin_text.GetComponent<Text>().text = _Manager.FormatNumberShort(_Manager.slot_price_2);
        }
        if (gameObject.name.Equals("slot3"))
        {
            coin_text.GetComponent<Text>().text = _Manager.FormatNumberShort(_Manager.slot_price_3);
        }
        if (gameObject.name.Equals("slot4"))
        {
            coin_text.GetComponent<Text>().text = _Manager.FormatNumberShort(_Manager.slot_price_4);
        }
        if (gameObject.name.Equals("slot6"))
        {
            coin_text.GetComponent<Text>().text = _Manager.FormatNumberShort(_Manager.slot_price_6);
        }
        if (gameObject.name.Equals("slot7"))
        {
            coin_text.GetComponent<Text>().text = _Manager.FormatNumberShort(_Manager.slot_price_7);
        }
        if (gameObject.name.Equals("slot8"))
        {
            coin_text.GetComponent<Text>().text = _Manager.FormatNumberShort(_Manager.slot_price_8);
        }
        if (gameObject.name.Equals("slot9"))
        {
            coin_text.GetComponent<Text>().text = _Manager.FormatNumberShort(_Manager.slot_price_9);
        }
        if (gameObject.name.Equals("slot10"))
        {
            coin_text.GetComponent<Text>().text = _Manager.FormatNumberShort(_Manager.slot_price_10);
        }
        if (gameObject.name.Equals("slot11"))
        {
            coin_text.GetComponent<Text>().text = _Manager.FormatNumberShort(_Manager.slot_price_11);
        }
        if (gameObject.name.Equals("slot12"))
        {
            coin_text.GetComponent<Text>().text = _Manager.FormatNumberShort(_Manager.slot_price_12);
        }
        if (gameObject.name.Equals("slot13"))
        {
            coin_text.GetComponent<Text>().text = _Manager.FormatNumberShort(_Manager.slot_price_13);
        }
        if (gameObject.name.Equals("slot14"))
        {
            coin_text.GetComponent<Text>().text = _Manager.FormatNumberShort(_Manager.slot_price_14);
        }
        if (gameObject.name.Equals("slot15"))
        {
            coin_text.GetComponent<Text>().text = _Manager.FormatNumberShort(_Manager.slot_price_15);
        }
        if (gameObject.name.Equals("slot16"))
        {
            coin_text.GetComponent<Text>().text = _Manager.FormatNumberShort(_Manager.slot_price_16);
        }
        if (gameObject.name.Equals("slot17"))
        {
            coin_text.GetComponent<Text>().text = _Manager.FormatNumberShort(_Manager.slot_price_17);
        }
        if (gameObject.name.Equals("slot18"))
        {
            coin_text.GetComponent<Text>().text = _Manager.FormatNumberShort(_Manager.slot_price_18);
        }
        if (gameObject.name.Equals("slot19"))
        {
            coin_text.GetComponent<Text>().text = _Manager.FormatNumberShort(_Manager.slot_price_19);
        }
        if (gameObject.name.Equals("slot20"))
        {
            coin_text.GetComponent<Text>().text = _Manager.FormatNumberShort(_Manager.slot_price_20);
        }
        if (gameObject.name.Equals("slot21"))
        {
            coin_text.GetComponent<Text>().text = _Manager.FormatNumberShort(_Manager.slot_price_21);
        }
        if (gameObject.name.Equals("slot22"))
        {
            coin_text.GetComponent<Text>().text = _Manager.FormatNumberShort(_Manager.slot_price_22);
        }
        if (gameObject.name.Equals("slot23"))
        {
            coin_text.GetComponent<Text>().text = _Manager.FormatNumberShort(_Manager.slot_price_23);
        }
        if (gameObject.name.Equals("slot24"))
        {
            coin_text.GetComponent<Text>().text = _Manager.FormatNumberShort(_Manager.slot_price_24);
        }
        if (gameObject.name.Equals("slot25"))
        {
            coin_text.GetComponent<Text>().text = _Manager.FormatNumberShort(_Manager.slot_price_25);
        }
        if (gameObject.name.Equals("slot26"))
        {
            coin_text.GetComponent<Text>().text = _Manager.FormatNumberShort(_Manager.slot_price_26);
        }
        if (gameObject.name.Equals("slot27"))
        {
            coin_text.GetComponent<Text>().text = _Manager.FormatNumberShort(_Manager.slot_price_27);
        }
        if (gameObject.name.Equals("slot28"))
        {
            coin_text.GetComponent<Text>().text = _Manager.FormatNumberShort(_Manager.slot_price_28);
        }
        if (gameObject.name.Equals("slot29"))
        {
            coin_text.GetComponent<Text>().text = _Manager.FormatNumberShort(_Manager.slot_price_29);
        }
        if (gameObject.name.Equals("slot30"))
        {
            coin_text.GetComponent<Text>().text = _Manager.FormatNumberShort(_Manager.slot_price_30);
        }
        if (gameObject.name.Equals("slot31"))
        {
            coin_text.GetComponent<Text>().text = _Manager.FormatNumberShort(_Manager.slot_price_31);
        }
        if (gameObject.name.Equals("slot32"))
        {
            coin_text.GetComponent<Text>().text = _Manager.FormatNumberShort(_Manager.slot_price_32);
        }
        if (gameObject.name.Equals("slot33"))
        {
            coin_text.GetComponent<Text>().text = _Manager.FormatNumberShort(_Manager.slot_price_33);
        }
        if (gameObject.name.Equals("slot34"))
        {
            coin_text.GetComponent<Text>().text = _Manager.FormatNumberShort(_Manager.slot_price_34);
        }
        if (gameObject.name.Equals("slot35"))
        {
            coin_text.GetComponent<Text>().text = _Manager.FormatNumberShort(_Manager.slot_price_35);
        }
        if (gameObject.name.Equals("slot36"))
        {
            coin_text.GetComponent<Text>().text = _Manager.FormatNumberShort(_Manager.slot_price_36);
        }
        if (gameObject.name.Equals("slot37"))
        {
            coin_text.GetComponent<Text>().text = _Manager.FormatNumberShort(_Manager.slot_price_37);
        }
        if (gameObject.name.Equals("slot38"))
        {
            coin_text.GetComponent<Text>().text = _Manager.FormatNumberShort(_Manager.slot_price_38);
        }
    }
}
