
var app = new Vue({
    el: '#app',
    data: {

        loading: false,
        products: [],
        productModel: {
            name: "name",
            description: "description",
            value:"6"

        }
    },
    methods: {
        getProducts() {
            this.loading = true
            axios.get('/Admin/products')
                .then(res => {
                    console.log(res)
                    this.products = res.data
                })
                .catch(err => {
                    console.log(err)
                })
                .then(() => {
                    this.loading = false
                })
        },
        createProduct() {
            this.loading = true
            axios.post('/Admin/products', this.productModel)
                .then(res => {
                    console.log(res)
                    this.products = res.data
                })
                .then(res => {
                    console.log(res)
                    this.products = res.data
                })
                .catch(err => {
                    console.log(err)
                })
                .then(() => {
                    this.loading = false
                })
        } 
    },
    computed: {

    }
    });