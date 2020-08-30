/*
    OOP'taki gibi bir varlığı ve niteliklerini tanımlamanın yolu struct veri tipidir
*/

fn main() {
    // Product tipinde bir struct nesnesi örnekledik
    // Aksi belirtilmedikçe struct türleri de immutable'dır
    // Sonradan içeriklerinde değişiklik yapacaksak mut ile mutable hale getirilmelidir
    let mouse = Product {
        title: String::from("El Ci Kablosuz Mouse"),
        company: String::from("Azon Manufacturing Company"),
        unit_price: 44.50,
        stock_level: 100,
        is_usable: false,
    };
    write_to_console(mouse); //Ekrana bilgilerini yazıracağımı bir metot kullanayım dedim

    // mouse.company = String::from("New Company"); // mouse değişkeni mutable tanımlanmadığı için hata verir

    let monitor = create_product(
        String::from("Filips 24 inch monitor"),
        String::from("Northwind Enterteintmant"),
        340.50,
        45,
    );
    write_to_console(monitor);
}

// Parametrelerden yararlanarak geriye Product örneği döndüren fonksiyonumuz
fn create_product(title: String, company: String, unit_price: f32, stock_level: i16) -> Product {
    /*
        metot parametre adları ile struct alan adları aynı olduğu için aşağıdaki gibi bir kullanım mümkün.
        yani title:title, company:company gibi atamalar yapmak zorunda değiliz
    */
    Product {
        title,
        company,
        unit_price,
        stock_level,
        is_usable: false,
    }
}

fn write_to_console(p: Product) {
    println!(
        "\n{} ({})\n{} dalır.\nStokta {} adet var.\nŞu an satışta mı? {}",
        p.title,
        p.company,
        p.unit_price,
        p.stock_level,
        if p.is_usable { "evet" } else { "hayır" }
    );
}

// Product isimli bir struct
struct Product {
    title: String,
    company: String,
    unit_price: f32,
    stock_level: i16,
    is_usable: bool,
}
