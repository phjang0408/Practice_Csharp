class Configuration
{
    List<ItemValue> listConfig = new List<ItemValue>();

    public void SetConfig(string item, string value)
    {
        ItemValue iv = new ItemValue();
        iv.SetValue(this, item, value);
    }

    public string GetConfig(string item)
    {
        foreach (ItemValue iv in listConfig)
        {
            if (iv.GetItem() == item)
                return iv.GetValue();
        }
        return null;
    }
    // 중첩 클래스가 private면, Configuration에서만 사용가능
    private class ItemValue
    {
        private string item;
        private string value;

        public void SetValue(Configuration config, string item, string value)
        {
            // 빈 config를 채워넣고
            this.item = item;
            this.value = value;
            bool found = false;
            // 이미 같은 item이 있으면 덮어쓰기
            for (int i = 0; i < config.listConfig.Count; i++)
            {
                if (config.listConfig[i].item == item)
                {
                    config.listConfig[i] = this;
                    found = true;
                    break;
                }
            }
            // 없으면 새로 추가
            if (found == false)
                config.listConfig.Add(this);
        }

        public string GetItem() { return item; }
        public string GetValue() { return value; }
    }

    static void Main(string[] args)
    {
        Configuration Config = new Configuration();

        // Confi 리스트에 하나씩 추가
        Config.SetConfig("Version", "V 5.0");
        Config.SetConfig("Size", "655,324 KB");

        Console.WriteLine(Config.GetConfig("Version"));  // V 5.0
        Console.WriteLine(Config.GetConfig("Size"));     // 655,324 KB

        Config.SetConfig("Version", "V 5.0.1");
        Console.WriteLine(Config.GetConfig("Version"));  // V 5.0.1
    }
}