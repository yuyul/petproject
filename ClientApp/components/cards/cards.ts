import Vue from 'vue';
import { Component } from 'vue-property-decorator';

@Component
export default class CardsComponent extends Vue {
    cards: String[] = [];
    id: String;

    created() {
        console.log(this.$route) // this should not throw TS errors now
        if (this.$route.params.id) {
            this.id = this.$route.params.id;
        } else {
            this.id = '';
        }
    }

    mounted() {
        var url = 'api/Card/Get';

        if (this.id.length > 0) {
            url = 'api/Card/GetByTeam' + '/' + this.id;
        }
        console.log(url);
        fetch(url)
            .then(response => response.json() as Promise<String[]>)
            .then(data => {
                console.log(data);
                this.cards = data;
            });
    }
}