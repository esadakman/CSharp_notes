# Csharp_notes

- Youtube üzerinde 'Yazılım Teknolojileri Akademisi' tarafından yayınlanmış olan 'C# Dersleri' başlıklı video serisini izlerken almış olduğum çalışma notlarım.

İlgili video serisine [burdan](https://www.youtube.com/watch?v=3t0rU5Yo4nM&list=PLi1BmHvgBkxIYweLR52cRJnit4AEEugn4) ulaşabilirsiniz.

## session_001_Visual_Studio Notları:

- Yorum kısayolu (ctrl+k) + (ctrl+C) veya manuel olarak `//` yazarak tek satırı, `/* text */` diyerek birden fazla satırı yoruma alabiliriz.
- Solution Explorer kısayolu (ctrl+Alt+L)
- Toolbox Explorer kısayolu (ctrl+Alt+X)
- Eklemeyi istediğimiz tool'ları toolbox'dan seçip sürükleyerek formumuza ekleyebiliriz
- comboBox html'de ki select tag'ine benzer.
- ComboBox sınıfı, yöntemini kullanarak IndexOf belirtilen nesneyi arar.
- comboBoxNames.Items.Add diyerek comboBox'a item ekleyebiliriz
- SelectedItemComboBox , bu nesneyi listede o anda seçili olan nesne yapmaya çalışır.

## session_002_GUI_Window_Forms Notları:

- labelWrittenName.Text diyerek oluşturduğumuz label'a dinamik olarak text yazdırabiliriz
- dateTimePicker ile tarih seçici ekleyebiliriz
- trackBarVolume ile'de trackBar seçeneği ekleyebiliriz
- Eklenen ögelerin yeni satırda eklenmesi için '\n' ifadesini ekliyebiliriz

## session_003_RadioButton_CheckBox_Panel

- Radio button'ın checkbox'tan farkı sadece bir tanesinin seçilebilmesidir
- Radio button'ın default seçili gelmesi için ise 'Checked' kısmını true yapmamız gerekiyor
- Projeyi çalıştırırken bazen değişiklikler anında gözükmeyebiliyor. öyle bir durumda 'Build' kısmından 'Clean Solution' deyip tekrar çalıştırmalıyız
- Panel kullanarak ekranımı bölebilir, çeşitli customization'lar yapabilirim
- herhangi bir eventi kaldırmak istediğimiz zaman öncelikle ilgili kod satırını silmemiz, ardından ise solution explorerda yer alan Designer'ın üzerine çift tıklayıp hata veren satırları siliyoruz

## session_004_Variables_Data_Types

- Değişken tanımlarken void dışında tanımlarsak Form1 classında ki diğer yerlerde de kullanabiliriz.
- Değişkenler'i Tek satırda tanımlayabileceğim gibi iki ayrı satırda da tanımlayabilirim
`string isim; 
 isim = textBox1.Text;`
- String istenen yere integer yazdığımız zaman bu veriyi kullanmak istersek int'e çevirmemiz gerekiyor, bunun için Convert.ToInt16(var_name) veya Int16.Parse(var_name) metodlarını kullanabiliriz
- Integer'a çevirmek için ise Convert.ToString(var_name) veya ToString(var_name) metodlarını kullanabiliriz

## session_005_Data_Types _Float_DoubleChar

- float: 7 decimal digits, double: 15 decimal digits alır
- float ile sayı tanımlarken sonuna 'f' eklemek gerekir, `float x = 5.123456789f;`  
- double'ı kullanırken sonuna herhangi bir harf yazmamıza gerek yok fakat  double daha fazla yer kaplar.
- Char veri türü, Unicode standardında eşdeğer karakterler içeren 16 bitlik bir veri türüdür. Her karakterin Unicode standart çerçevesinde karşılık gelen bir karakteri vardır ve char türüne bir değişken değeri atadıktan sonra bir karakteri temsil eder.
-  char tanımlarken tek tırnak olarak tanımlamamız gerekir

## session_006_Arithmetic_Operations

- Formda boş bir yere tıklayarak form ismini ve iconu gibi özellikleri değiştirebiliriz
- Bir sayının üssünü almak için Math.Pow func. kullanabiliriz.
- Fakat Math.Pow() double döndüğü için ya sonucu (int) diyerek integere'a çeviririz ya da değişkenimizi double olarak belirleriz

## session_007_Geometric_Calculator

- 