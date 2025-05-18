# 📂 FileWatcherConsoleApp

Bu .NET 8 Console uygulaması belirli bir klasörü (örneğin `Downloads`) izler ve aşağıdaki dosya sistem olaylarına tepki verir:

- 🟢 Yeni dosya geldiğinde bildirir
- 📄 `.txt` dosyaları varsa içeriğini okur
- ✏️ Dosya yeniden adlandırıldığında bildirir
- 🗑️ Silinen dosyaları listeler

## 🧰 Kullanılan Teknolojiler

| Teknoloji        | Açıklama                             |
|------------------|--------------------------------------|
| .NET 8 Console   | Uygulama yapısı ve çalışma ortamı    |
| FileSystemWatcher| Gerçek zamanlı dosya sistemi izleme  |
| System.IO        | Dosya okuma/yazma işlemleri          |
| C#               | Uygulama dili                        |
| UTF-8            | `.txt` içeriği kodlaması             |

---

## 🛠 Kullanım

```bash
dotnet run
