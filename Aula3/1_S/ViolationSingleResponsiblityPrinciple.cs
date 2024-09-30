
namespace Aula3._1_S
{
    public class ViolationSingleResponsiblityPrinciple
    {
        //sabe demais ou faz demais

        //informar
        public void calculateTotalSum() {/*...*/}
        public void getItems() {/*...*/}
        public void getItemCount() {/*...*/}
        public void addItem(Item item) {/*...*/}
        public void deleteItem(Item item) {/*...*/}

        //exibir
        public void printPedido() {/*...*/}
        public void showPedido() {/*...*/}

        //manipular
        public void load() {/*...*/}
        public void save() {/*...*/}
        public void update() {/*...*/}
        public void delete() {/*...*/}
    }
}
