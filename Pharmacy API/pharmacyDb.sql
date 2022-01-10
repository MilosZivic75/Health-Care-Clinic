
CREATE TABLE public."AdvertisementMedicine" (
    "AdvertisementId" integer NOT NULL,
    "MedicineId" integer NOT NULL
);


ALTER TABLE public."AdvertisementMedicine" OWNER TO postgres;

--
-- TOC entry 211 (class 1259 OID 43963)
-- Name: Advertisements; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."Advertisements" (
    "Id" integer NOT NULL,
    "Title" text,
    "Description" text
);


ALTER TABLE public."Advertisements" OWNER TO postgres;

--
-- TOC entry 210 (class 1259 OID 43962)
-- Name: Advertisements_Id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

ALTER TABLE public."Advertisements" ALTER COLUMN "Id" ADD GENERATED BY DEFAULT AS IDENTITY (
    SEQUENCE NAME public."Advertisements_Id_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- TOC entry 213 (class 1259 OID 43971)
-- Name: ApiKeys; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."ApiKeys" (
    "Id" integer NOT NULL,
    "Name" text,
    "Key" text,
    "BaseUrl" text,
    "Category" text
);


ALTER TABLE public."ApiKeys" OWNER TO postgres;

--
-- TOC entry 212 (class 1259 OID 43970)
-- Name: ApiKeys_Id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

ALTER TABLE public."ApiKeys" ALTER COLUMN "Id" ADD GENERATED BY DEFAULT AS IDENTITY (
    SEQUENCE NAME public."ApiKeys_Id_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- TOC entry 215 (class 1259 OID 43979)
-- Name: FeedbackReplies; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."FeedbackReplies" (
    "Id" integer NOT NULL,
    "Text" text,
    "SenderId" integer NOT NULL,
    "ReceiverId" integer NOT NULL,
    "TimeOfSending" timestamp without time zone NOT NULL,
    "FeedbackId" integer NOT NULL
);


ALTER TABLE public."FeedbackReplies" OWNER TO postgres;

--
-- TOC entry 214 (class 1259 OID 43978)
-- Name: FeedbackReplies_Id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

ALTER TABLE public."FeedbackReplies" ALTER COLUMN "Id" ADD GENERATED BY DEFAULT AS IDENTITY (
    SEQUENCE NAME public."FeedbackReplies_Id_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- TOC entry 217 (class 1259 OID 43987)
-- Name: Feedbacks; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."Feedbacks" (
    "Id" integer NOT NULL,
    "Text" text,
    "SenderId" integer NOT NULL,
    "ReceiverId" integer NOT NULL,
    "TimeOfSending" timestamp without time zone NOT NULL
);


ALTER TABLE public."Feedbacks" OWNER TO postgres;

--
-- TOC entry 216 (class 1259 OID 43986)
-- Name: Feedbacks_Id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

ALTER TABLE public."Feedbacks" ALTER COLUMN "Id" ADD GENERATED BY DEFAULT AS IDENTITY (
    SEQUENCE NAME public."Feedbacks_Id_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- TOC entry 219 (class 1259 OID 43995)
-- Name: Medicines; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."Medicines" (
    "Id" integer NOT NULL,
    "Name" text,
    "Quantity" integer NOT NULL,
    "Manufacturer" text,
    "Usage" text,
    "Weight" integer NOT NULL,
    "SideEffects" text,
    "Reactions" text,
    "CompatibileMedicine" text,
    "Price" double precision NOT NULL
);


ALTER TABLE public."Medicines" OWNER TO postgres;

--
-- TOC entry 218 (class 1259 OID 43994)
-- Name: Medicines_Id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

ALTER TABLE public."Medicines" ALTER COLUMN "Id" ADD GENERATED BY DEFAULT AS IDENTITY (
    SEQUENCE NAME public."Medicines_Id_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- TOC entry 221 (class 1259 OID 44003)
-- Name: Messages; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."Messages" (
    "Id" integer NOT NULL,
    "Sender" text,
    "MessageText" text,
    "Receiver" text
);


ALTER TABLE public."Messages" OWNER TO postgres;

--
-- TOC entry 220 (class 1259 OID 44002)
-- Name: Messages_Id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

ALTER TABLE public."Messages" ALTER COLUMN "Id" ADD GENERATED BY DEFAULT AS IDENTITY (
    SEQUENCE NAME public."Messages_Id_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- TOC entry 223 (class 1259 OID 44011)
-- Name: TenderResponses; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."TenderResponses" (
    "Id" integer NOT NULL,
    "TenderId" integer NOT NULL,
    "PharmacyName" text,
    "TotalPrice_Amount" double precision,
    "Description" text,
    "IsWinningBid" boolean NOT NULL
);


ALTER TABLE public."TenderResponses" OWNER TO postgres;

--
-- TOC entry 222 (class 1259 OID 44010)
-- Name: TenderResponses_Id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

ALTER TABLE public."TenderResponses" ALTER COLUMN "Id" ADD GENERATED BY DEFAULT AS IDENTITY (
    SEQUENCE NAME public."TenderResponses_Id_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- TOC entry 228 (class 1259 OID 44042)
-- Name: TenderResponses_TenderItems; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."TenderResponses_TenderItems" (
    "Id" integer NOT NULL,
    "TenderResponseId" integer NOT NULL,
    "Name" text,
    "Quantity" integer NOT NULL
);


ALTER TABLE public."TenderResponses_TenderItems" OWNER TO postgres;

--
-- TOC entry 227 (class 1259 OID 44041)
-- Name: TenderResponses_TenderItems_Id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

ALTER TABLE public."TenderResponses_TenderItems" ALTER COLUMN "Id" ADD GENERATED BY DEFAULT AS IDENTITY (
    SEQUENCE NAME public."TenderResponses_TenderItems_Id_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- TOC entry 225 (class 1259 OID 44019)
-- Name: Tenders; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."Tenders" (
    "Id" integer NOT NULL,
    "DateRange_Start" timestamp without time zone,
    "DateRange_End" timestamp without time zone,
    "Description" text
);


ALTER TABLE public."Tenders" OWNER TO postgres;

--
-- TOC entry 224 (class 1259 OID 44018)
-- Name: Tenders_Id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

ALTER TABLE public."Tenders" ALTER COLUMN "Id" ADD GENERATED BY DEFAULT AS IDENTITY (
    SEQUENCE NAME public."Tenders_Id_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- TOC entry 230 (class 1259 OID 44055)
-- Name: Tenders_TenderItems; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."Tenders_TenderItems" (
    "Id" integer NOT NULL,
    "TenderId" integer NOT NULL,
    "Name" text,
    "Quantity" integer NOT NULL
);


ALTER TABLE public."Tenders_TenderItems" OWNER TO postgres;

--
-- TOC entry 229 (class 1259 OID 44054)
-- Name: Tenders_TenderItems_Id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

ALTER TABLE public."Tenders_TenderItems" ALTER COLUMN "Id" ADD GENERATED BY DEFAULT AS IDENTITY (
    SEQUENCE NAME public."Tenders_TenderItems_Id_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- TOC entry 209 (class 1259 OID 43957)
-- Name: __EFMigrationsHistory; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."__EFMigrationsHistory" (
    "MigrationId" character varying(150) NOT NULL,
    "ProductVersion" character varying(32) NOT NULL
);


ALTER TABLE public."__EFMigrationsHistory" OWNER TO postgres;

--
-- TOC entry 3237 (class 2606 OID 44030)
-- Name: AdvertisementMedicine PK_AdvertisementMedicine; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."AdvertisementMedicine"
    ADD CONSTRAINT "PK_AdvertisementMedicine" PRIMARY KEY ("AdvertisementId", "MedicineId");


--
-- TOC entry 3220 (class 2606 OID 43969)
-- Name: Advertisements PK_Advertisements; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Advertisements"
    ADD CONSTRAINT "PK_Advertisements" PRIMARY KEY ("Id");


--
-- TOC entry 3222 (class 2606 OID 43977)
-- Name: ApiKeys PK_ApiKeys; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."ApiKeys"
    ADD CONSTRAINT "PK_ApiKeys" PRIMARY KEY ("Id");


--
-- TOC entry 3224 (class 2606 OID 43985)
-- Name: FeedbackReplies PK_FeedbackReplies; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."FeedbackReplies"
    ADD CONSTRAINT "PK_FeedbackReplies" PRIMARY KEY ("Id");


--
-- TOC entry 3226 (class 2606 OID 43993)
-- Name: Feedbacks PK_Feedbacks; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Feedbacks"
    ADD CONSTRAINT "PK_Feedbacks" PRIMARY KEY ("Id");


--
-- TOC entry 3228 (class 2606 OID 44001)
-- Name: Medicines PK_Medicines; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Medicines"
    ADD CONSTRAINT "PK_Medicines" PRIMARY KEY ("Id");


--
-- TOC entry 3230 (class 2606 OID 44009)
-- Name: Messages PK_Messages; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Messages"
    ADD CONSTRAINT "PK_Messages" PRIMARY KEY ("Id");


--
-- TOC entry 3232 (class 2606 OID 44017)
-- Name: TenderResponses PK_TenderResponses; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."TenderResponses"
    ADD CONSTRAINT "PK_TenderResponses" PRIMARY KEY ("Id");


--
-- TOC entry 3239 (class 2606 OID 44048)
-- Name: TenderResponses_TenderItems PK_TenderResponses_TenderItems; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."TenderResponses_TenderItems"
    ADD CONSTRAINT "PK_TenderResponses_TenderItems" PRIMARY KEY ("TenderResponseId", "Id");


--
-- TOC entry 3234 (class 2606 OID 44025)
-- Name: Tenders PK_Tenders; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Tenders"
    ADD CONSTRAINT "PK_Tenders" PRIMARY KEY ("Id");


--
-- TOC entry 3241 (class 2606 OID 44061)
-- Name: Tenders_TenderItems PK_Tenders_TenderItems; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Tenders_TenderItems"
    ADD CONSTRAINT "PK_Tenders_TenderItems" PRIMARY KEY ("TenderId", "Id");


--
-- TOC entry 3218 (class 2606 OID 43961)
-- Name: __EFMigrationsHistory PK___EFMigrationsHistory; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."__EFMigrationsHistory"
    ADD CONSTRAINT "PK___EFMigrationsHistory" PRIMARY KEY ("MigrationId");


--
-- TOC entry 3235 (class 1259 OID 44067)
-- Name: IX_AdvertisementMedicine_MedicineId; Type: INDEX; Schema: public; Owner: postgres
--

CREATE INDEX "IX_AdvertisementMedicine_MedicineId" ON public."AdvertisementMedicine" USING btree ("MedicineId");


--
-- TOC entry 3242 (class 2606 OID 44031)
-- Name: AdvertisementMedicine FK_AdvertisementMedicine_Advertisements_AdvertisementId; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."AdvertisementMedicine"
    ADD CONSTRAINT "FK_AdvertisementMedicine_Advertisements_AdvertisementId" FOREIGN KEY ("AdvertisementId") REFERENCES public."Advertisements"("Id") ON DELETE CASCADE;


--
-- TOC entry 3243 (class 2606 OID 44036)
-- Name: AdvertisementMedicine FK_AdvertisementMedicine_Medicines_MedicineId; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."AdvertisementMedicine"
    ADD CONSTRAINT "FK_AdvertisementMedicine_Medicines_MedicineId" FOREIGN KEY ("MedicineId") REFERENCES public."Medicines"("Id") ON DELETE CASCADE;


--
-- TOC entry 3244 (class 2606 OID 44049)
-- Name: TenderResponses_TenderItems FK_TenderResponses_TenderItems_TenderResponses_TenderResponseId; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."TenderResponses_TenderItems"
    ADD CONSTRAINT "FK_TenderResponses_TenderItems_TenderResponses_TenderResponseId" FOREIGN KEY ("TenderResponseId") REFERENCES public."TenderResponses"("Id") ON DELETE CASCADE;


--
-- TOC entry 3245 (class 2606 OID 44062)
-- Name: Tenders_TenderItems FK_Tenders_TenderItems_Tenders_TenderId; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Tenders_TenderItems"
    ADD CONSTRAINT "FK_Tenders_TenderItems_Tenders_TenderId" FOREIGN KEY ("TenderId") REFERENCES public."Tenders"("Id") ON DELETE CASCADE;


-- Completed on 2022-01-10 20:33:47

--
-- PostgreSQL database dump complete
--

INSERT INTO public."Advertisements" ("Id", "Title", "Description") VALUES (1, 'Super ponuda', 'NIkada jeftiniji popust');


--
-- TOC entry 3395 (class 0 OID 43995)
-- Dependencies: 219
-- Data for Name: Medicines; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public."Medicines" ("Id", "Name", "Quantity", "Manufacturer", "Usage", "Weight", "SideEffects", "Reactions", "CompatibileMedicine", "Price") VALUES (1, 'Brufen', 400, 'Bayer', 'Pain relief', 400, 'Rash, Stomach pain', 'Headache', 'Aspirin', 4.5);
INSERT INTO public."Medicines" ("Id", "Name", "Quantity", "Manufacturer", "Usage", "Weight", "SideEffects", "Reactions", "CompatibileMedicine", "Price") VALUES (2, 'Klacid', 200, 'Bayer', 'Lung infections, Bronchitis', 500, 'Rash, Unconsciousness', 'Headache, Swelling', 'Aspirin', 5);
INSERT INTO public."Medicines" ("Id", "Name", "Quantity", "Manufacturer", "Usage", "Weight", "SideEffects", "Reactions", "CompatibileMedicine", "Price") VALUES (3, 'Paracetamol', 250, 'Galenika', 'Toothache, Headache', 500, 'None', 'None', 'Aspirin', 5.25);


--
-- TOC entry 3402 (class 0 OID 44026)
-- Dependencies: 226
-- Data for Name: AdvertisementMedicine; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- TOC entry 3389 (class 0 OID 43971)
-- Dependencies: 213
-- Data for Name: ApiKeys; Type: TABLE DATA; Schema: public; Owner: postgres
--



