var watcher = new FileSystemWatcher();
watcher.Path = @"C:\Users\W10\Downloads";
watcher.Filter = "*.*";

watcher.IncludeSubdirectories = false;
watcher.NotifyFilter = NotifyFilters.FileName | NotifyFilters.LastWrite;

// Yeni dosya eklendi
watcher.Created += (s, e) =>
{
    if (Path.GetExtension(e.FullPath).ToLower() == ".txt")
    {
        try
        {
           
            Thread.Sleep(500);

            string content = File.ReadAllText(e.FullPath);
            Console.WriteLine($"📄 Yeni .txt dosya: {e.Name}");
            Console.WriteLine("📝 İçerik:");
            Console.WriteLine(content);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"❌ Dosya okunamadı: {e.Name} ({ex.Message})");
        }
    }
    else
    {
        Console.WriteLine($"🟢 Yeni dosya (txt değil): {e.Name}");
    }
};


// Dosya silindi
watcher.Deleted += (s, e) =>
{
    Console.WriteLine($"🗑️ Silinen dosya: {e.Name}");
};

// Dosya ismi değişti
watcher.Renamed += (s, e) =>
{
    Console.WriteLine($"✏️ Dosya adı değişti: {e.OldName} → {e.Name}");
};

// Dosya içeriği değişti (isteğe bağlı)
watcher.Changed += (s, e) =>
{
    Console.WriteLine($"✍️ Dosya değişti: {e.Name}");
};


watcher.EnableRaisingEvents = true;

Console.WriteLine("📡 'İndirilenler' klasörü izleniyor. Çıkmak için ESC.");
while (Console.ReadKey().Key != ConsoleKey.Escape) ;
